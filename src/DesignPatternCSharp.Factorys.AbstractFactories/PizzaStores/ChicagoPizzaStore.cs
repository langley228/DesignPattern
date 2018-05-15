using DesignPatternCSharp.Factorys.AbstractFactories.PizzaFactories;
using DesignPatternCSharp.Factorys.AbstractFactories.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var factory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "Chicago Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
