using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject
{
    abstract class USCoin : Coin
    {

        enum USCoingMintMark
        {
            P,
            D,
            S,
            W
        }

        public USCoin() { }

        public string About()
        {
            return "About";
        }

        public string GetMintNameFromMark()
        {

            return "Mint Name Method";
        }

    }
}
