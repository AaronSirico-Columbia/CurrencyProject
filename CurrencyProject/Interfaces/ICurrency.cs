using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProject.Interfaces
{
    public interface ICurrency
    {
        double MonetaryValue { get; set; }
        string Name { get; }

        string About()
        {
            return "About";
        }
    }
}
