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
        public float Date;

        [Column("1")]
        public float Price;

        [Column("2")]
        public float Amount;

        [Column("3")]
        public float Transaction;

        [Column(ordinal: "4")]
        public float Type;

        [Column(ordinal: "5", name: "Label")]
        public float Decision;
    }
}
