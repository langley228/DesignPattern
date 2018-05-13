using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.Doughs
{
    public class ThickCrustDough : IDough
    {
        public string Name { get; } = "Thick Crust Dough";
    }
}
