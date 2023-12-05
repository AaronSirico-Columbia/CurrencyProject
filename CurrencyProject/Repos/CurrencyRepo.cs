using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyProject.Interfaces;


namespace CurrencyProject.Repos
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICurrency> Currency { get; set; }

        public List<ICoin> Coins { get; set; }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }


        public string about()
        {
            return "About";
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count();
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            return MakeChange(Amount, 0);
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            CurrencyRepo p = new CurrencyRepo();
            return p;

        }

        public ICurrencyRepo CreateChange(double Amount)
        {
            return CreateChange(Amount, 0);
        }

        public ICurrencyRepo CreateChange(double Amount, double TotalCost)
        {
            CurrencyRepo p = new CurrencyRepo();
            return p;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        public double TotalValue()
        {
            double total = 0; 
            foreach(ICurrency c in Currency)
            {
                total += c.MonetaryValue;
            }
            return total;
        }

        double ICurrencyRepo.CreateChange(double v)
        {
            throw new NotImplementedException();
        }
    }
}
