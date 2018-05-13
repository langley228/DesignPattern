using DesignPatternCSharp.Factorys.Ioc.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.PizzaFactories
{
    public class PizzaIngredientFactory : IPizzaIngredientFactory
    {
        private readonly string _createNamespace = "DesignPatternCSharp.Factorys.Ioc";
        private readonly PizzaElement _pizzaElement;
        public PizzaIngredientFactory(PizzaElement pizzaElement)
        {
            _pizzaElement = pizzaElement;
        }
        public IDough CreateDough()
        {
            return Create("Doughs", _pizzaElement.Dough) as IDough;
        }

        public ICheese CreateCheese()
        {
            return Create("Cheeses", _pizzaElement.Cheese) as ICheese;
        }

        public IClams CreateClams()
        {
            return Create("Clamses", _pizzaElement.Clams) as IClams;
        }

        public ISauce CreateSauce()
        {
            return Create("Sauces", _pizzaElement.Sauce) as ISauce;
        }
        private object Create(string namespaceType, string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            else
                return Create($"{_createNamespace}.{namespaceType}.{name}");

        }
        private static object Create(string className, object[] args = null)
        {
            Assembly asmb = typeof(PizzaIngredientFactory).Assembly;
            return asmb.CreateInstance(className, true, BindingFlags.CreateInstance, null, args, null, null);
        }
    }
}
