using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 無法飛行的行為
    /// </summary>
    public class FlyNoWay : IFly
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
