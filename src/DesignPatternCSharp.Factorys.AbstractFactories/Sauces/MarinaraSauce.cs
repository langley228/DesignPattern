using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.Sauces
{
    public class MarinaraSauce : ISauce
    {
        public string Name { get; } = "Marinara Sauce";
    }
}
