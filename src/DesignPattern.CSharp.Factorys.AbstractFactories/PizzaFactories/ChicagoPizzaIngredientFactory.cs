using DesignPattern.CSharp.Factorys.AbstractFactories.Cheeses;
using DesignPattern.CSharp.Factorys.AbstractFactories.Clamses;
using DesignPattern.CSharp.Factorys.AbstractFactories.Doughs;
using DesignPattern.CSharp.Factorys.AbstractFactories.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.AbstractFactories.PizzaFactories
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
