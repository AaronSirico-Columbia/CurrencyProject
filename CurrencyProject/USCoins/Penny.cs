using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyProject.Currency.US;

namespace CurrencyProject.USCoins
{
    public class Penny : USCoin
    {
        
        public Penny() { }

       

        public Penny(USCoinMintMark mark) : base(mark)
        {
            
        }

        public string About()
        {
            return "US Penny is from 2017. It is worth $0.01. It was made in Denver";
        }
    }
}
