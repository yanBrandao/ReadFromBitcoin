using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin.Modelo
{
    public class Ticker
    {
        public double high { get; set; }
        public double low { get; set; }
        public double vol { get; set; }
        public double last { get; set; }
        public double buy { get; set; }
        public double sell { get; set; }
        public int date { get; set; }
    }
}
