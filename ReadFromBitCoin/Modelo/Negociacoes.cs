using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin.Modelo
{
    class Negociacoes
    {
        public int date { get; set; }
        public double price { get; set; }
        public double amount { get; set; }
        public int tid { get; set; }
        public string type { get; set; }
    }
}
