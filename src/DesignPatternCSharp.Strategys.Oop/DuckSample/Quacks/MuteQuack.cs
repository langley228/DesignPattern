using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 沒有叫聲的行為
    /// </summary>
    public class MuteQuack : IQuack
    {
        public void quack()
        {
            Console.WriteLine("I say ...(Silence)");
        }
    }
}
