using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyProject.Interfaces;

namespace CurrencyProject.USCoins
{
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }

        public string Name { get; set; }



        public Coin()
        {



        }

        public string About()
        {

            return "About";
        }


    }
}
