using DesignPatternCSharp.Factorys.Ioc.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.Ioc
{
    class Program
    {
        public static void Sample()
        {
            var c = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            PizzaStoreData s = (PizzaStoreData)c.GetSection("PizzaStoreData");
            foreach (PizzaStoreElement pizzaStore in s.PizzaStores)
            {
                Console.WriteLine($"PizzaStore: {pizzaStore.DisplayName}");
                pizzaStore.OrderPizza("cheese");
                pizzaStore.OrderPizza("clams");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
