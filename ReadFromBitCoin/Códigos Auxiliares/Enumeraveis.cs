using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin.Códigos_Auxiliares
{
    public class Enumeraveis
    {
        public enum Moedas
        {
            [Description("Bitcoin")]
            BTC,
            [Description("Litecoin")]
            LTC,
            [Description("BCash")]
            BCH,
            [Description("Ripple")]
            XRP
        }
    }
}
