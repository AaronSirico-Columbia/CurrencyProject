using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Repos
{
    internal class UKCurrencyRepo : CurrencyRepo
    {
        public UKCurrencyRepo()
        {
        }

        public static explicit operator UKCurrencyRepo(double v)
        {
            throw new NotImplementedException();
        }
    }
}
