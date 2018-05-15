using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 誘餌鴨
    /// </summary>
    public class DecoyDuck : Duck, IDuck
    {
        /// <summary>
        /// 誘餌鴨
        /// </summary>
        public DecoyDuck()
            : base(new FlyNoWay(), new MuteQuack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real decoy duck");
        }
    }
}
