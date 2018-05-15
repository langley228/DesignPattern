using DesignPatternCSharp.Factorys.AbstractFactories.PizzaStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories
{
    public class Program
    {
        public static void Sample()
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza("cheese");

            Console.WriteLine("-----------------------------------------------------------");

            var chicagoYorkPizzaStore = new ChicagoPizzaStore();
            chicagoYorkPizzaStore.OrderPizza("cheese");
            
        }
    }
}
