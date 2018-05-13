using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternCSharp.Factorys.AbstractFactories.Cheeses;
using DesignPatternCSharp.Factorys.AbstractFactories.Clamses;
using DesignPatternCSharp.Factorys.AbstractFactories.Doughs;
using DesignPatternCSharp.Factorys.AbstractFactories.Sauces;

namespace DesignPatternCSharp.Factorys.AbstractFactories.PizzaFactories
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }
    }
}
