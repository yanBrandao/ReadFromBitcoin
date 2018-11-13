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
using Newtonsoft.Json.Linq;
using Microsoft.ML.Runtime;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReadFromBitCoin
{
    public partial class Frm_Home : Form
    {
        double myAmount = 0;
        double myWallet = 500;
        int sinceParam = 2285709;
        int lerJSONs = 1;

        double maxValue;
        double minValue;

        static int contTransações = 0;
        static int contDias = 0;
        static int ultimaTransação = 0;

        List<double> chartWallet = new List<double>();
        List<double> chartSell = new List<double>();
        List<double> priceWallet = new List<double>();

        string requestMercadoBitcoin = "https://www.mercadobitcoin.net/api/";
        bool runningTaskMercado = false;
        bool runningTaskTrades = false;

        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static string TrainBitcoinDataPath => Path.Combine(AppPath, "dataset", "bitcoin-train-set.csv");
        private static string TestBitcoinDataPath => Path.Combine(AppPath, "dataset", "bitcoin-test-set.csv");

        //private static string TrainBitcoinDataPath => Path.Combine(AppPath, "dataset", "new-bitcoin-train-set.csv");
        //private static string TestBitcoinDataPath => Path.Combine(AppPath, "dataset", "new-bitcoin-test-set.csv");
        private static string ModelPath => Path.Combine(AppPath, "BitCoin.zip");


        List<BitCoinData> input = new List<BitCoinData>();

        public Frm_Home()
        {
            InitializeComponent();
            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Scroll += (sender, e) => { pTreinamento.VerticalScroll.Value = vScrollBar1.Value; };
            pTreinamento.Controls.Add(vScrollBar1);
            
            //ReadCoin(Enumeraveis.Moedas.BTC);
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

        void ReadCoin(Enumeraveis.Moedas moeda)
        {
            String JSON = Request(moeda, "ticker", richTicker);
            JObject JCoin = JsonConvert.DeserializeObject<JObject>(JSON);
            Ticker tick = JsonConvert.DeserializeObject<Ticker>(JCoin["ticker"].ToString());
            minValue = tick.low;
            maxValue = tick.high;

            String s = Request(Enumeraveis.Moedas.BTC, "trades", richTrade);

            JArray JTrades = JsonConvert.DeserializeObject<JArray>(s);

            foreach (object item in JTrades)
            {
                Negociacoes trade = JsonConvert.DeserializeObject<Negociacoes>(item.ToString());
                BitCoinData _bitCoinData = new BitCoinData();
                _bitCoinData.Date = trade.date;
                _bitCoinData.Transaction = trade.tid;
                _bitCoinData.Amount = (float)trade.amount;
                _bitCoinData.Price = (float)trade.price;
                _bitCoinData.Type = (trade.type == "sell") ? 1 : 0;

                input.Add(_bitCoinData);

                if (richTrade.InvokeRequired)
                {
                    richTrade.Invoke(new Action(() => richTrade.Text += "\r\n"));
                }
                else
                {
                    richTrade.Text += Convert.ToInt32(_bitCoinData.Date) +
                                      _bitCoinData.Price + ", " +
                                      _bitCoinData.Amount + ", " + 
                                      _bitCoinData.Transaction + "\r\n";
                }
            }

            #region Criação da Base de Teste diária
            if (!File.Exists(TrainBitcoinDataPath))
            {
                btnMercadoBitCoin_Click(this, new EventArgs());
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(TrainBitcoinDataPath))
                {
                    Console.WriteLine(maxValue);
                }
            }


            #endregion
        }

        private void ReadJSON()
        {
            while (runningTaskMercado)
            {
                Request(Enumeraveis.Moedas.BTC, "ticker", richTicker);
                System.Threading.Thread.Sleep(24000);
            }
        }
        private void ReadJSONTrades()
        {
            while (runningTaskTrades)
            {
                Request(Enumeraveis.Moedas.BTC, "trades", richTrade);
                Task.Run(() => Frm_Home_LoadAsync(lbScroll));
                System.Threading.Thread.Sleep(5000);
            }
        }
        
        public string Request(Enumeraveis.Moedas moeda, string tipo, RichTextBox textBox)
        {
            string returnS;
            Console.WriteLine("Request " + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            string totalURL = requestMercadoBitcoin + moeda + "/" + tipo + "/";
            if (tipo == "trades")
                returnS = this.HttpGetForTrades(totalURL, textBox);
            else
                returnS = this.HttpGetForCoins(totalURL, textBox);
            return returnS;
        }

        public string HttpGetForCoins(string URI, RichTextBox textBox)
        {
            WebClient cliente = new WebClient();

            cliente.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = cliente.OpenRead(URI);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            JObject trades = JsonConvert.DeserializeObject<JObject>(s);
            Ticker tick = JsonConvert.DeserializeObject<Ticker>(trades["ticker"].ToString());
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => textBox.Text += "================================================\r\n"
                                                             + "Máximo: " + tick.high + "\r\n"
                                                             + "Mínimo: " + tick.low + "\r\n"
                                                             + "Compra: " + tick.buy + "\r\n"
                                                             + "Venda: " + tick.sell + "\r\n"
                                                             + "Data: " + (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(tick.date).ToString() + "\r\n"
                                                             + "=================================================\r\n")));
            }
            else
            {
                textBox.Text += s + "\r\n";
            }
            data.Close();
            reader.Close();

            return s;
        }


        public string HttpGetForTrades(string URI, RichTextBox textBox)
        {
            WebClient cliente = new WebClient();

            cliente.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            string s = string.Empty;
            

            int since = sinceParam;
            string helpURI = URI;
            for (int i = 0; i < lerJSONs; i++)
            {

                URI = helpURI + "?since=" + since;

                Stream data = cliente.OpenRead(URI);
                StreamReader reader = new StreamReader(data);
                s = reader.ReadToEnd();
                JArray trades = JsonConvert.DeserializeObject<JArray>(s);
                BitCoinData _bitCoinData = new BitCoinData();

                foreach (object item in trades)
                {

                    Negociacoes trade = JsonConvert.DeserializeObject<Negociacoes>(item.ToString());
                    _bitCoinData = new BitCoinData();
                    _bitCoinData.Date = trade.date;
                    _bitCoinData.Transaction = trade.tid;
                    _bitCoinData.Amount = (float)trade.amount;
                    _bitCoinData.Price = (float)trade.price;
                    _bitCoinData.Type = (trade.type == "sell") ? 1 : 0;

                    input.Add(_bitCoinData);
                }
                if (textBox.InvokeRequired)
                {
                    textBox.Invoke(new Action(() => textBox.Text += s + "\r\n"));
                }
                else
                {
                    textBox.Text += s + "\r\n";
                }
                since = Convert.ToInt32(_bitCoinData.Transaction);
                data.Close();
                reader.Close();
            }
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
        }

        public void Frm_Home_Load(object sender, EventArgs e)
        {
            lbHora.Text = "Início: " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            Task.Run(() => Frm_Home_LoadAsync(lbScroll));
        }

        public async Task Frm_Home_LoadAsync(ListBox scrollLabel)
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
                        scrollLabel.Invoke(new Action(() => scrollLabel.Items.Add(result)));
                    }
                }
                else
                {
                    int index = 0;
                    foreach(BitCoinData item in input)
                    {
                        var prediction = model.Predict(item);
                        index++;
                        string result = $"[{index}] I have to trade? {(item.Type == 1 ? "Sell" : "Buy")}   Predicted: {(prediction.Decision)}";
                        if (prediction.Decision) {
                            bool deal = false;
                            if (item.Type == 1 && myAmount - item.Amount > 0)
                            {
                                //Se for venda, eu ganho dinheiro e perco bitCoin.
                                myWallet += item.Price * item.Amount;
                                myAmount -= item.Amount;
                                deal = true;
                            }
                            else if (item.Type == 0 && myWallet - (item.Price * item.Amount) > 0)
                            {
                                //Se for compra, eu gasto dinheiro e ganho bitCoin.
                                myWallet -= item.Price * item.Amount;
                                myAmount += item.Amount;
                                deal = true;
                            }
                            if (deal)
                            {
                                lbCarteira.Invoke(new Action(() => lbCarteira.Text = "Carteira: " + myWallet));
                                lbMoedas.Invoke(new Action(() => lbMoedas.Text = "Quantidade de Moedas: " + myAmount));

                                DateTime hoje = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(item.Date);
                                lbHistorico.Invoke(new Action(() => lbHistorico.Items.Add($"{(item.Type == 1 ? "Venda" : "Compra")} realizada {(deal == true ? "com sucesso." : "sem sucesso. (Falta de Moedas)")} - {hoje.ToShortDateString() + " " + hoje.ToShortTimeString()} - (Quantidade: {item.Amount}) (Valor: {item.Price}) ")));

                                #region Programação do Gráfico
                                if (deal && item.Type == 1)
                                {
                                    if (ultimaTransação == 0)
                                        ultimaTransação = Convert.ToInt32(item.Date);
                                    else
                                    {
                                        if (item.Date > ultimaTransação)
                                            contDias++;
                                        ultimaTransação = Convert.ToInt32(item.Date);
                                    }
                                    contTransações++;
                                    lbTransacoes.Invoke(new Action(() => lbTransacoes.Text = "Quantidade de Transações: " + contTransações));
                                    lbHistorico.Invoke(new Action(() => lbHistorico.Items[lbHistorico.Items.Count - 1].BackColor = Color.Green));
                                    using (StreamWriter file = new StreamWriter(TestBitcoinDataPath, true))
                                    {
                                        file.WriteLine(@"{0}, {1}, {2}, {3}, {4}, {5}", Convert.ToInt32(item.Date), item.Price.ToString("0.000000000"), item.Amount.ToString("0.00000000"), item.Transaction, item.Type, (prediction.Decision == true ? 1 : 0));
                                    }
                                    //for (int i = graficoCarteira.Series.Count - 1; i >= 0; i--)
                                    //{
                                    //    graficoCarteira.Series.RemoveAt(i);
                                    //}
                                    //chartWallet.Clear();
                                    //chartWallet.Add(myWallet);
                                    //priceWallet.Add(item.Price);
                                    //var series = new Series("Venda");
                                    //series.ChartType = SeriesChartType.Line;
                                    //// Frist parameter is X-Axis and Second is Collection of Y- Axis
                                    //series.Points.DataBindXY(priceWallet, chartWallet);
                                    //graficoCarteira.Series.Add(series);

                                    //var series2 = new Series("Compra");
                                    //series2.ChartType = SeriesChartType.Line;
                                    //// Frist parameter is X-Axis and Second is Collection of Y- Axis
                                    //series2.Points.DataBindXY(priceWallet, chartWallet);
                                    //graficoCarteira.Series.Add(series2);

                                }
                                else if (deal && item.Type == 0)
                                {
                                    if (ultimaTransação == 0)
                                        ultimaTransação = Convert.ToInt32(item.Date);
                                    else
                                    {
                                        if (item.Date > ultimaTransação)
                                            contDias++;
                                        ultimaTransação = Convert.ToInt32(item.Date);
                                    }


                                    contTransações++;
                                    lbTransacoes.Invoke(new Action(() => lbTransacoes.Text = "Quantidade de Transações: " + contTransações));
                                    lbHistorico.Invoke(new Action(() => lbHistorico.Items[lbHistorico.Items.Count - 1].BackColor = Color.Blue));
                                    using (StreamWriter file = new StreamWriter(TestBitcoinDataPath, true))
                                    {
                                        file.WriteLine(@"{0}, {1}, {2}, {3}, {4}, {5}", Convert.ToInt32(item.Date), item.Price.ToString("0.000000000"), item.Amount.ToString("0.00000000"), item.Transaction, item.Type, (prediction.Decision == true ? 1 : 0));
                                    }
                                    //    for (int i = graficoCarteira.Series.Count - 1; i >= 0; i--)
                                    //    {
                                    //        graficoCarteira.Series.RemoveAt(i);
                                    //    }

                                    //    chartWallet.Add(myWallet);
                                    //    priceWallet.Add(item.Price);
                                    //    var series = new Series("Venda");
                                    //    series.ChartType = SeriesChartType.Line;
                                    //    // Frist parameter is X-Axis and Second is Collection of Y- Axis
                                    //    series.Points.DataBindXY(priceWallet, chartWallet);
                                    //    graficoCarteira.Series.Add(series);

                                    //    var series2 = new Series("Compra");
                                    //    series2.ChartType = SeriesChartType.Line;
                                    //    // Frist parameter is X-Axis and Second is Collection of Y- Axis
                                    //    series2.Points.DataBindXY(priceWallet, chartWallet);
                                    //    graficoCarteira.Series.Add(series2);
                                }
                                lbDias.Invoke(new Action(() => lbDias.Text = "Dias contabilizados: " + contDias));
                                #endregion
                            }
                        }

                        if (scrollLabel.InvokeRequired)
                        {
                            scrollLabel.Invoke(new Action(() => scrollLabel.Items.Add(result)));
                        }
                    }
                }
                input.Clear();

            }catch(Exception ex)
            {
                Debug.WriteLine("Log Home LoadAsync " + ex.Message);
            }
        }


        public static async Task<PredictionModel<BitCoinData, BitCoinPrediction>> TrainAsyncBitcoin(ListBox scroll)
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
                    "Date",
                    "Price",
                    "Amount",
                    "Transaction",
                    "Type"));

                // FastTreeBinaryClassifier is an algorithm that will be used to train the model.
                // It has three hyperparameters for tuning decision tree performance. 
                pipeline.Add(new FastTreeBinaryClassifier() {
                    NumTrees = 100,
                    LearningRates = 0.4f,
                    DropoutRate = 0.05f
                });
                //pipeline.Add(new FastTreeRegressor() {
                //    NumTrees = 1,
                //    EarlyStoppingRule = new GLEarlyStoppingCriterion(),
                //    LearningRates = 0.4f,
                //    DropoutRate = 0.05f
                //});

                scroll.Invoke(new Action(() => scroll.Items.Add("=============== Training model ===============" + "\r\n")));

                // The pipeline is trained on the dataset that has been loaded and transformed.
                model = pipeline.Train<BitCoinData, BitCoinPrediction>();

                // Saving the model as a .zip file.
                await model.WriteAsync(ModelPath);

                scroll.Invoke(new Action(() => scroll.Items.Add(("=============== End training ===============") + "\r\n")));

                scroll.Invoke(new Action(() => scroll.Items.Add(("The model is saved to {0}", ModelPath) + "\r\n")));


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro na Task(TrainAsync)" + ex.Message);
            }
            return model;
        }

        private static void EvaluateBitcoin(PredictionModel<BitCoinData, BitCoinPrediction> model, ListBox scroll)
        {
            // To evaluate how good the model predicts values, the model is ran against new set
            // of data (test data) that was not involved in training.
            var testData = new TextLoader(TestBitcoinDataPath).CreateFrom<BitCoinData>(useHeader: true, separator: ',');

            // BinaryClassificationEvaluator performs evaluation for Binary Classification type of ML problems.
            var evaluator = new BinaryClassificationEvaluator();

            scroll.Invoke(new Action(() => scroll.Items.Add("=============== Evaluating model ===============" + "\r\n")));
            

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

            scroll.Invoke(new Action(() => scroll.Items.Add("Accuracy: {metrics.Accuracy:P2}" + "\r\n")));
            scroll.Invoke(new Action(() => scroll.Items.Add($"Auc: {metrics.Auc:P2}" + "\r\n")));
            scroll.Invoke(new Action(() => scroll.Items.Add($"F1Score: {metrics.F1Score:P2}" + "\r\n")));
            scroll.Invoke(new Action(() => scroll.Items.Add("=============== End evaluating ===============" + "\r\n")));
            scroll.Invoke(new Action(() => scroll.Items.Add("\r\n")));
        }

        private void richTicker_TextChanged(object sender, EventArgs e)
        {
            richTicker.SelectionStart = richTicker.Text.Length;
            richTicker.ScrollToCaret();
        }

        private void richTrade_TextChanged(object sender, EventArgs e)
        {
            richTrade.SelectionStart = richTicker.Text.Length;
            richTrade.ScrollToCaret();
        }

        private void lbHistorico_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void lbScroll_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void lbScroll_MouseHover(object sender, EventArgs e)
        {
            lbScroll.SelectedIndex = lbScroll.Items.Count - 1;
            lbScroll.TopIndex = lbScroll.Items.Count - 1;
        }

    }
}
