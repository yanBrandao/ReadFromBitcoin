using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using ReadFromBitCoin.Códigos_Auxiliares;
using System.IO;
using JArray = Newtonsoft.Json.Linq.JArray;

using Newtonsoft.Json;
using ReadFromBitCoin.Modelo;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Transforms;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Models;
using System.Diagnostics;

namespace ReadFromBitCoin
{
    public partial class Frm_Home : Form
    {

        string requestMercadoBitcoin = "https://www.mercadobitcoin.net/api/";
        bool runningTaskMercado = false;
        bool runningTaskTrades = false;
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static string TrainBitcoinDataPath => Path.Combine(AppPath, "dataset", "bitcoin-train-set.csv");
        private static string TestBitcoinDataPath => Path.Combine(AppPath, "dataset", "bitcoin-test-set.csv");
        private static string ModelPath => Path.Combine(AppPath, "BitCoin.zip");

        List<BitCoinData> input = new List<BitCoinData>();

        public Frm_Home()
        {
            InitializeComponent();
        }

        private void btnMercadoBitCoin_Click(object sender, EventArgs e)
        {
            if (btnTicker.Text.Equals("Stop"))
            {
                btnTicker.Text = "Ticker";
                runningTaskMercado = false;
            }
            else
            {
                btnTicker.Text = "Stop";
                runningTaskMercado = true;
                Task.Factory.StartNew(() => { ReadJSON(); });
            }
            Application.DoEvents();
        }

        private void ReadJSON()
        {
            while (runningTaskMercado)
            {
                Request(Enumeraveis.Moedas.BTC, "ticker", richTicker);
                System.Threading.Thread.Sleep(800);
            }
        }
        private void ReadJSONTrades()
        {
            while (runningTaskTrades)
            {
                Request(Enumeraveis.Moedas.BTC, "trades", richTrade);
                System.Threading.Thread.Sleep(800);
            }
        }
        
        public string Request(Enumeraveis.Moedas moeda, string tipo, RichTextBox textBox)
        {
            Console.WriteLine("Request " + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            string totalURL = requestMercadoBitcoin + moeda + "/" + tipo + "/";

            return this.HttpGet(totalURL, textBox);
        }

        public string HttpGet(string URI, RichTextBox textBox)
        {
            WebClient cliente = new WebClient();

            cliente.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = cliente.OpenRead(URI);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            JArray trades = JsonConvert.DeserializeObject<JArray>(s);
            
            foreach(object item in trades)
            {
                
                Negociacoes trade = JsonConvert.DeserializeObject<Negociacoes>(item.ToString());
            }
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => textBox.Text += s + "\r\n"));
            }
            else
            {
                textBox.Text += s + "\r\n";
            }
            data.Close();
            reader.Close();

            return s;
        }

        private void btnTrades_Click(object sender, EventArgs e)
        {
            if (btnTrades.Text.Equals("Stop"))
            {
                btnTrades.Text = "Trades";
                runningTaskTrades = false;
            }
            else
            {
                btnTrades.Text = "Stop";
                runningTaskTrades = true;
                Task.Factory.StartNew(() => { ReadJSONTrades(); });
            }
            Application.DoEvents();
            Task.Run(() => Frm_Home_LoadAsync(lbScroll));
        }

        public void Frm_Home_Load(object sender, EventArgs e)
        {
            Task.Run(() => Frm_Home_LoadAsync(lbScroll));
        }

        public async Task Frm_Home_LoadAsync(Label scrollLabel)
        {
            try
            {
                var model = await TrainAsyncBitcoin(scrollLabel);

                // STEP2: Test accuracy
                EvaluateBitcoin(model, scrollLabel);

                // STEP 3: Make a prediction
                if (input.Count <= 0)
                {
                    var prediction = model.Predict(TesteBitCoin.Trade);

                    string result = $"I have to trade? {(TesteBitCoin.Trade.Type == 1 ? "Sell" : "Buy")}   Predicted: {(prediction.Decision)}";

                    if (scrollLabel.InvokeRequired)
                    {
                        scrollLabel.Invoke(new Action(() => scrollLabel.Text += result));
                    }
                }
                else
                {
                    foreach(BitCoinData item in input)
                    {
                        var prediction = model.Predict(item);

                        string result = $"I have to trade? {(TesteBitCoin.Trade.Type == 1 ? "Sell" : "Buy")}   Predicted: {(prediction.Decision)}";

                        if (scrollLabel.InvokeRequired)
                        {
                            scrollLabel.Invoke(new Action(() => scrollLabel.Text += result));
                        }
                    }
                }
                

            }catch(Exception ex)
            {
                Debug.WriteLine("Log Home LoadAsync " + ex.Message);
            }
        }


        public static async Task<PredictionModel<BitCoinData, BitCoinPrediction>> TrainAsyncBitcoin(Label scroll)
        {
            PredictionModel<BitCoinData, BitCoinPrediction> model = null;
            try
            {// LearningPipeline holds all steps of the learning process: data, transforms, learners.  
                var pipeline = new LearningPipeline();

                // The TextLoader loads a dataset. The schema of the dataset is specified by passing a class containing
                // all the column names and their types.
                pipeline.Add(new TextLoader(TrainBitcoinDataPath).CreateFrom<BitCoinData>(useHeader: true, separator: ','));

                // Transform any text feature to numeric values
                //pipeline.Add(new CategoricalOneHotVectorizer(
                //    "Label"));

                // Put all features into a vector
                pipeline.Add(new ColumnConcatenator(
                    "Features",
                    "Price",
                    "Amount",
                    "Type"));

                // FastTreeBinaryClassifier is an algorithm that will be used to train the model.
                // It has three hyperparameters for tuning decision tree performance. 
                pipeline.Add(new FastTreeBinaryClassifier() { NumLeaves = 5, NumTrees = 5, MinDocumentsInLeafs = 2 });
                //pipeline.Add(new StochasticDualCoordinateAscentClassifier());

                scroll.Invoke(new Action(() => scroll.Text += "=============== Training model ===============" + "\r\n"));

                // The pipeline is trained on the dataset that has been loaded and transformed.
                model = pipeline.Train<BitCoinData, BitCoinPrediction>();

                // Saving the model as a .zip file.
                await model.WriteAsync(ModelPath);

                scroll.Invoke(new Action(() => scroll.Text += ("=============== End training ===============") + "\r\n"));

                scroll.Invoke(new Action(() => scroll.Text += ("The model is saved to {0}", ModelPath) + "\r\n"));


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro na Task(TrainAsync)" + ex.Message);
            }
            return model;
        }

        private static void EvaluateBitcoin(PredictionModel<BitCoinData, BitCoinPrediction> model, Label scroll)
        {
            // To evaluate how good the model predicts values, the model is ran against new set
            // of data (test data) that was not involved in training.
            var testData = new TextLoader(TestBitcoinDataPath).CreateFrom<BitCoinData>(useHeader: true, separator: ',');

            // BinaryClassificationEvaluator performs evaluation for Binary Classification type of ML problems.
            var evaluator = new BinaryClassificationEvaluator();

            scroll.Invoke(new Action(() => scroll.Text += "=============== Evaluating model ===============" + "\r\n"));
            

            var metrics = evaluator.Evaluate(model, testData);
            // BinaryClassificationMetrics contains the overall metrics computed by binary classification evaluators
            // The Accuracy metric gets the accuracy of a classifier which is the proportion 
            //of correct predictions in the test set.

            // The Auc metric gets the area under the ROC curve.
            // The area under the ROC curve is equal to the probability that the classifier ranks
            // a randomly chosen positive instance higher than a randomly chosen negative one
            // (assuming 'positive' ranks higher than 'negative').

            // The F1Score metric gets the classifier's F1 score.
            // The F1 score is the harmonic mean of precision and recall:
            //  2 * precision * recall / (precision + recall).

            scroll.Invoke(new Action(() => scroll.Text += $"Accuracy: {metrics.Accuracy:P2}" + "\r\n"));
            scroll.Invoke(new Action(() => scroll.Text += $"Auc: {metrics.Auc:P2}" + "\r\n"));
            scroll.Invoke(new Action(() => scroll.Text += $"F1Score: {metrics.F1Score:P2}" + "\r\n"));
            scroll.Invoke(new Action(() => scroll.Text += "=============== End evaluating ===============" + "\r\n"));
            scroll.Invoke(new Action(() => scroll.Text += "\r\n"));
        }


    }
}
