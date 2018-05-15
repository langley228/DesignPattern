using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.OopAndFp.DuckSample
{
    public static class FlyFactory
    {
        /// <summary>
        /// 無法飛行的行為
        /// </summary>
        public static void FlyNoWay()
        {
            Console.WriteLine("I can't fly");
        }
        /// <summary>
        /// 用翅膀飛行的行為
        /// </summary>

        public static void FlyWithWings()
        {
            Console.WriteLine("I'm flying with my wings");
        }
    }
}
