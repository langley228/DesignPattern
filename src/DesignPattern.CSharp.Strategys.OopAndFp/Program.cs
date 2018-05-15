using DesignPattern.CSharp.Strategys.OopAndFp.DuckSample;
using DesignPattern.CSharp.Strategys.OopAndFp.SortSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.OopAndFp
{

    public class Program
    {
        public static void Sample()
        {
            Console.WriteLine("=== StrategySample.OopAndFp ====");
            List<IDuck> duckList = new List<IDuck>();
            duckList.Add(new DecoyDuck());
            duckList.Add(new MallardDuck());
            duckList.Add(new RedheadDuck());
            duckList.Add(new RubberDuck());
            duckList.Add(new ModelDuck(FlyFactory.FlyNoWay, QuackFactory.Squeak));
            duckList.Add(new ModelDuck(
                () => Console.WriteLine("try Fly Method"),
                () => Console.WriteLine("try Quack Method")));
            foreach (var duck in duckList)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();

            }
            int[] s1 = { -19, 20, 41, 23, -6 };
            s1.BSort((a, b) => a > b ? 1 : (b > a) ? -1 : 0);
            foreach (var n in s1)
                Console.WriteLine(n);
            double[] s2 = { -19.3, 20.6, 41.0, 23.6, -6.0 };
            s2.BSort((a, b) => a > b ? 1 : (b > a) ? -1 : 0);
            foreach (var n in s1)
                Console.WriteLine(n);
        }
    }
}
