using DesignPatternCSharp.Factorys.AbstractFactories.PizzaFactories;
using DesignPatternCSharp.Factorys.AbstractFactories.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.PizzaStores
{
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            var factory = new NewYorkPizzaIngredientFactory();
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "New York Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "New York Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
