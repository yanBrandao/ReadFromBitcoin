using ReadFromBitCoin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromBitCoin
{
    internal class TesteBitCoin
    {
        internal static readonly BitCoinData Trade = new BitCoinData()
        {
            Price = 24800.08000000f,
            Amount = 0.00211754f,
            Type = 0 // 0 Para Compra e 1 Para Venda
        };
    }
}
