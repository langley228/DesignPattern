using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.SimpleFactories.Beverages
{
    public class Program
    {
        public static void Sample()
        {
            BeverageStores store = new BeverageStores(new SimpleBeverageFactory());
            Console.WriteLine("A 客人點了 {0}" , store.BeverageOrders("GreenTea").DisplayName);
            Console.WriteLine("B 客人點了 {0}", store.BeverageOrders("BlackTea").DisplayName);
            Console.WriteLine("C 客人點了 {0}", store.BeverageOrders("cc").DisplayName);
            Console.ReadLine();
        }
    }
}
