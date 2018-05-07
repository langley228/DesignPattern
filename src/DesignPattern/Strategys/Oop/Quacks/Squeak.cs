﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop
{
    /// <summary>
    /// 吱吱叫的行為
    /// </summary>
    public class Squeak : IQuack
    {
        public void quack()
        {
            Console.WriteLine("I say Squeak");
        }
    }
}
