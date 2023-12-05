using CurrencyProject.Interfaces;
using CurrencyProject.UKCoins;
using CurrencyProject.USCoins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject
{
    public static class Currency
    {
        public struct US
        {

            public enum USCoinMintMark
            {
                P,
                D,
                S,
                W
            }

            public static Dictionary<USCoinMintMark, string> USCoinMintMarkDict = new Dictionary<USCoinMintMark, string>
            {
                {USCoinMintMark.P, "Philadelphia"},
                {USCoinMintMark.D, "Denver"},
                {USCoinMintMark.S, "San Francisco"},
                {USCoinMintMark.W, "West Point"}
            };

            public static Dictionary<Type, double> USCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Penny), 0.01},
                {typeof(Nickel), 0.05},
                {typeof(Dime), 0.10},
                {typeof(Quarter), 0.25},
                {typeof(HalfDollar), 0.50},
                {typeof(DollarCoin), 1.00}
            };

            public static Dictionary<Type, string> USCoinNameDict = new Dictionary<Type, string>
            {
                {typeof(Penny), "Penny"},
                {typeof(Nickel), "Nickel"},
                {typeof(Dime), "Dime"},
                {typeof(Quarter), "Quarter"},
                {typeof(HalfDollar), "Half Dollar"},
                {typeof(DollarCoin), "Dollar Coin"}
            };

            public static Dictionary<Type, Dictionary<Enum, string>> CurMintMarkDict = new Dictionary<Type, Dictionary<Enum, string>>()
        {
            {typeof(USCoin), GetMintMarkDict(US.USCoinMintMarkDict)},
        };

            static Dictionary<Enum, string> GetMintMarkDict<TEnum>(Dictionary<TEnum, string> mintMarkDict)
            where TEnum : Enum
            {
                if (mintMarkDict is null) { throw new ArgumentNullException(nameof(mintMarkDict)); }

                var resultDict = new Dictionary<Enum, string>();

                foreach (var entry in mintMarkDict)
                {
                    resultDict.Add(entry.Key, entry.Value);
                }

                return resultDict;
            }

        }

        public struct UK
        {

            public enum UKCoinMintMark
            {

                R,
                B,
                M,
                E
            }

            public static Dictionary<UKCoinMintMark, string> UKCoinMintMarkDict = new Dictionary<UKCoinMintMark, string>
            {
                {UKCoinMintMark.R, "Royal Mint"},
                {UKCoinMintMark.B, "Birmingham Mint"},
                {UKCoinMintMark.M, "Manchester Mint"},
                {UKCoinMintMark.E, "Edinburgh Mint"}
            };

            public static Dictionary<Type, double> UKCoinValueDict = new Dictionary<Type, double>
            {
                {typeof(Pence), 0.01},
                {typeof(TwoPence), 0.02},
                {typeof(FivePence), 0.05},
                {typeof(TenPence), 0.10},
                {typeof(TwentyPence), 0.20},
                {typeof(FiftyPence), 0.5},
                {typeof(Pound), 1.00},
                {typeof(TwoPound), 2.00}
            };

            public static Dictionary<Type, string> UKCoinNameDict = new Dictionary<Type, string>
            {
                {typeof(Pence), "Pence"},
                {typeof(TwoPence), "Two Pence"},
                {typeof(FivePence), "Five Pence"},
                {typeof(TenPence), "Ten Pence"},
                {typeof(TwentyPence), "Twenty Pence"},
                {typeof(FiftyPence), "Fifty Pence"},
                {typeof(Pound), "Pound"},
                {typeof(TwoPound), "Two Pound"}
            };
        }
    }
}
