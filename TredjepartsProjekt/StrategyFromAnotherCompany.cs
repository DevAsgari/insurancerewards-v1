using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TredjepartsProjekt
{
    public class StrategyFromAnotherCompany
    {

        public int calculate(int price)
        { return ((int)double.Round(0.2 * price)) + price; }

    }
}
