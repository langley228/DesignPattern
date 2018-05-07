using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop
{

    public class Program
    {
        public static void Sample()
        {
            Console.WriteLine("=== StrategySample.Oop ====");
            List<IDuck> duckList = new List<IDuck>();
            duckList.Add(new DecoyDuck());
            duckList.Add(new MallardDuck());
            duckList.Add(new RedheadDuck());
            duckList.Add(new RubberDuck());
            duckList.Add(new ModelDuck(new FlyNoWay(), new Squeak()));

            foreach (var duck in duckList)
            {
                duck.Display();
                duck.Fly.fly();
                duck.Quack.quack();
            }
            int[] s1 = { -19, 20, 41, 23, -6 };
            s1.BSort(new IntComparator());
            foreach (var n in s1)
                Console.WriteLine(n);
            double[] s2 = { -19.3, 20.6, 41.0, 23.6, -6.0 };
            s2.BSort(new DoubletComparator());
            foreach (var n in s1)
                Console.WriteLine(n);
        }
    }
}
