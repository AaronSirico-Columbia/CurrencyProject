using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyProject.Currency.US;

namespace CurrencyProject.USCoins
{
    public class Nickel : USCoin
    {
      
        public Nickel() { }

        public Nickel(USCoinMintMark mark) : base(mark)
        {

        }
    }
}
