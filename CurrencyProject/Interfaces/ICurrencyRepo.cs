using CurrencyProject.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Interfaces
{
    public interface ICurrencyRepo
    {

        public List<ICoin> Coins { get; set; }

        public string about();

        public void AddCoin(ICoin c);

        public int GetCoinCount();


        public ICoin RemoveCoin(ICoin c);

        public double TotalValue();

        public double CreateChange(double v);


    }
}
