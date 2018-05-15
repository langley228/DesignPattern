using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.CSharp.Factorys.AbstractFactories.Cheeses;
using DesignPattern.CSharp.Factorys.AbstractFactories.Clamses;
using DesignPattern.CSharp.Factorys.AbstractFactories.Doughs;
using DesignPattern.CSharp.Factorys.AbstractFactories.Sauces;

namespace DesignPattern.CSharp.Factorys.AbstractFactories.PizzaFactories
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
