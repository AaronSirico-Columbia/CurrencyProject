using CurrencyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.UKCoins
{
    internal class Pound : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }

        public string Name { get; set; }


    }
}
