using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop
{
    /// <summary>
    /// 模型鴨
    /// </summary>
    public class ModelDuck : Duck
    {
        /// <summary>
        /// 模型鴨
        /// </summary>
        public ModelDuck(IFly fly, IQuack quack) 
            : base(fly, quack)
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real model duck");
        }
    }
}
