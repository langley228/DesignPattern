using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 呱呱叫的行為
    /// </summary>
    public class Quack : IQuack
    {
        public void quack()
        {
            Console.WriteLine("I say Quack");
        }
    }
}
