using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.OopAndFp.DuckSample
{
    /// <summary>
    /// 綠頭鴨
    /// </summary>
    public class MallardDuck : Duck
    {
        /// <summary>
        /// 綠頭鴨
        /// </summary>
        public MallardDuck()
            : base(FlyFactory.FlyWithWings, QuackFactory.Quack)
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }
    }
}
