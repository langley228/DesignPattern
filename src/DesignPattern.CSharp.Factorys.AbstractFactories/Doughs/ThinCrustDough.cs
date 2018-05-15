using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.AbstractFactories.Doughs
{
    public class ThinCrustDough : IDough
    {
        public string Name { get; } = "Thin Crust Dough";
    }
}
