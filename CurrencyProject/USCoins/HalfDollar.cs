using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyProject.Currency.US;

namespace CurrencyProject.USCoins
{
    public class HalfDollar : USCoin
    {
       
        public HalfDollar() { }

        public HalfDollar(USCoinMintMark mark) : base(mark)
        {

        }
    }
}
