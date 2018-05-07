using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop
{
    /// <summary>
    /// 橡皮鴨
    /// </summary>
    public class RubberDuck : Duck
    {
        /// <summary>
        /// 橡皮鴨
        /// </summary>
        public RubberDuck()
            : base(new FlyNoWay(), new Squeak())
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real rubber duck");
        }
    }
}
