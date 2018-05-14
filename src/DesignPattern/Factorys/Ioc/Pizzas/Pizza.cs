using DesignPatternCSharp.Factorys.Ioc.Configuration;
using DesignPatternCSharp.Factorys.Ioc.PizzaFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc.Pizzas
{
    public class Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public Pizza(PizzaElement pizzaElement)
        {
            Name = pizzaElement.DisplayName;
            _pizzaIngredientFactory = new PizzaIngredientFactory(pizzaElement);
        }

        public string Name { get; protected set; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IClams Clams { get; protected set; }
        public void Prepare()
        {
            Console.WriteLine($"Preparing: {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Clams = _pizzaIngredientFactory.CreateClams();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Console.WriteLine($"    {Dough?.Name}");
            Console.WriteLine($"    {Sauce?.Name}");
            Console.WriteLine($"    {Clams?.Name}");
            Console.WriteLine($"    {Cheese?.Name}");
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagnol slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box......");
        }
    }
}
