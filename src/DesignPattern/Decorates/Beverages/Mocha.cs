using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Decorates.Beverages
{

    public class Mocha : Beverage
    {
        public Mocha()
        {
            Description = "Mocha";
            Cost = .20;
        }
    }
}
