using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin.Modelo
{
    public class BitCoinData
    {
        [Column("0")]
        public float Price;

        [Column("1")]
        public float Amount;

        [Column(ordinal: "2")]
        public float Type;

        [Column(ordinal: "3", name: "Label")]
        public float Decision;
    }
}
