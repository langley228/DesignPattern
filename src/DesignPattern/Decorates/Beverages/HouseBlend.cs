using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Decorates.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
            Cost = .89;
        }
    }
}
