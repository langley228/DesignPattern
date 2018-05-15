using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Decorates.Beverages
{

    public class Program
    {
        public static void Sample()
        {
            // 點了一杯 Espresso, 印出它的資訊
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} ${beverage.Cost}");

            // 再點一杯 Espresso
            Beverage beverage2 = new Espresso();

            // 加料, 改用 Append 方法 , 讓程式碼更易讀
            beverage2 = beverage2.Append(new Mocha())
                                 .Append(new Milk());
            Console.WriteLine($"{beverage2.Description} ${beverage2.Cost}");

            // 誰說覆水難收, 還原大法
            beverage2 = beverage2.Rollback();
            Console.WriteLine($"{beverage2.Description} ${beverage2.Cost}");

        }
    }
}
