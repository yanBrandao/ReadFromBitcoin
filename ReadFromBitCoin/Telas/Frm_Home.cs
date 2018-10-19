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

namespace ReadFromBitCoin
{
    public partial class Frm_Home : Form
    {

        string requestMercadoBitcoin = "https://www.mercadobitcoin.net/api/";
        bool runningTaskMercado = false;

        public Frm_Home()
        {
            InitializeComponent();
        }

        private void btnMercadoBitCoin_Click(object sender, EventArgs e)
        {
            if (btnMercadoBitCoin.Text.Equals("Stop"))
            {
                btnMercadoBitCoin.Text = "Mercado Bitcoin";
                runningTaskMercado = false;
            }
            else
            {
                btnMercadoBitCoin.Text = "Stop";
                runningTaskMercado = true;
                Task.Factory.StartNew(() => { ReadJSON(); });
            }
            Application.DoEvents();
        }

        private void ReadJSON()
        {
            while (runningTaskMercado)
            {
                Request(Enumeraveis.Moedas.BTC);
                Thread.Sleep(800);
            }
        }
        
        public string Request(Enumeraveis.Moedas moeda)
        {
            Console.WriteLine("Request " + DateTime.Now.Minute + ":" + DateTime.Now.Second);
            string totalURL = requestMercadoBitcoin + moeda + "/ticker/";

            return this.HttpGet(totalURL);
        }

        public string HttpGet(string URI)
        {
            WebClient cliente = new WebClient();

            cliente.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = cliente.OpenRead(URI);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }


    }
}
