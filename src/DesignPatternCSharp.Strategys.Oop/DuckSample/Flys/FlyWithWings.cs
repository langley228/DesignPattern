using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 用翅膀飛行的行為
    /// </summary>
    public class FlyWithWings : IFly
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with my wings");
        }
    }
}
