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
using System.Threading;
using JArray = Newtonsoft.Json.Linq.JArray;

using Newtonsoft.Json;
using ReadFromBitCoin.Modelo;

namespace ReadFromBitCoin
{
    public partial class Frm_Home : Form
    {

        string requestMercadoBitcoin = "https://www.mercadobitcoin.net/api/";
        bool runningTaskMercado = false;
        bool runningTaskTrades = false;

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
                Thread.Sleep(800);
            }
        }
        private void ReadJSONTrades()
        {
            while (runningTaskTrades)
            {
                Request(Enumeraveis.Moedas.BTC, "trades", richTrade);
                Thread.Sleep(800);
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
        }
    }
}
