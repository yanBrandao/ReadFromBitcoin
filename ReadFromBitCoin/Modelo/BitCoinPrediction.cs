using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin.Modelo
{
    public class BitCoinPrediction
    {
        [Column(ordinal: "0", name: "PredictedLabel")]
        public bool Decision;

        [Column(ordinal: "1", name: "Probability")]
        public float Probability;
    }
}
