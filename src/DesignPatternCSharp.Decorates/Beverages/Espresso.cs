using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Decorates.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
            Cost = 1.99;
        }
    }
}
