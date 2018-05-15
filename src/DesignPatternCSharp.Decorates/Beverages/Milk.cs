using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Decorates.Beverages
{
    public class Milk : Beverage
    {
        public Milk()
        {
            Description = "Milk";
            Cost = .30;
        }
    }
}
