using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject
{
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }

        public string Name => throw new NotImplementedException();

        public Coin()  
        { 
        
        
        
        }

        public string About()
        {

            return "About";
        }


    }
}
