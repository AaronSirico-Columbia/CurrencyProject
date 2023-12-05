using CurrencyProject.Interfaces;
using CurrencyProject.USCoins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Repos
{
    public class USCurrencyRepo : CurrencyRepo
    {
        public USCurrencyRepo()
        {
        }

        public static explicit operator USCurrencyRepo(double v)
        {
            throw new NotImplementedException();
        }
    }

}