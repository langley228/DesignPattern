using DesignPattern.CSharp.Factorys.Ioc.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.Ioc
{
    public class Program
    {
        public static void Sample()
        {
            PizzaStoreData pizzaStoreData = (PizzaStoreData)ConfigurationManager.GetSection("PizzaStoreData");
            foreach (PizzaStoreElement pizzaStore in pizzaStoreData.PizzaStores)
            {
                Console.WriteLine($"PizzaStore: {pizzaStore.DisplayName}");
                pizzaStore.OrderPizza("cheese");
                pizzaStore.OrderPizza("clams");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
