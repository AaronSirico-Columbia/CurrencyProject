using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyProject.Interfaces;
using CurrencyProject.USCoins;
using static CurrencyProject.Currency;
using static CurrencyProject.Currency.UK;

namespace CurrencyProject.UKCoins
{
    public class UKCoin : Coin
    {
        public UKCoinMintMark MintMark { get; set; }

        public UKCoin()
        {
            MintMark = UKCoinMintMark.R;
            Year = DateTime.Now.Year;
            Name = UKCoinNameDict[GetType()];
            MonetaryValue = UKCoinValueDict[GetType()];
         

        }

        public UKCoin(UKCoinMintMark mintMark)
        {
            MintMark = mintMark;
            Year = DateTime.Now.Year;
            Name = UKCoinNameDict[GetType()];
            MonetaryValue = UKCoinValueDict[GetType()];
        }
    
    }
}
