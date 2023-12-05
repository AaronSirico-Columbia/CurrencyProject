using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyProject.Interfaces;
using CurrencyProject.USCoins;
using static CurrencyProject.Currency;
using static CurrencyProject.Currency.US;

namespace CurrencyProject.USCoins
{
    public abstract class USCoin : Coin
    {

        public USCoinMintMark MintMark { get; set; }
       

        public USCoin() {
        
        MintMark = USCoinMintMark.D;
        Year = DateTime.Now.Year;
        Name = USCoinNameDict[GetType()];
        MonetaryValue = USCoinValueDict[GetType()];

        }

        public USCoin(USCoinMintMark mintMark)
        {

            MintMark = mintMark;
            Year = DateTime.Now.Year;
            Name = USCoinNameDict[GetType()];
            MonetaryValue = USCoinValueDict[GetType()];


        }

        public string About()
        {
            return "About";
        }

        //public static string GetMintNameFromMark(USCoinMintMark d)
        //{
        //    return USCoinMintMark[d];
        //}
    }
}
