﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 紅頭鴨
    /// </summary>
    public class RedheadDuck : Duck
    {
        /// <summary>
        /// 紅頭鴨
        /// </summary>
        public RedheadDuck() 
            : base(new FlyWithWings(), new Quack())
        {
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real redhead duck");
        }
    }
}
