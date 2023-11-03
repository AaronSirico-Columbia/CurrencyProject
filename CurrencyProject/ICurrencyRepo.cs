using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject
{
    internal interface ICurrencyRepo
    {

        List<ICoin> Coins { get; set; }

        string about()
        {
            return "About";
        }

        void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        int GetCoinCount()
        {
            return Coins.Count;
        }

        ICurrencyRepo MakeChange(double Amount)
        {
            return null;
        }

        ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {

            return null;

        }

        ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        double TotalValue()
        {
            return Coins.Count;
        }
    }
}
