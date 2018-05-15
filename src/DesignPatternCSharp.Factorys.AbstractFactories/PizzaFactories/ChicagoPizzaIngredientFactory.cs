using DesignPatternCSharp.Factorys.AbstractFactories.Cheeses;
using DesignPatternCSharp.Factorys.AbstractFactories.Clamses;
using DesignPatternCSharp.Factorys.AbstractFactories.Doughs;
using DesignPatternCSharp.Factorys.AbstractFactories.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.PizzaFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
