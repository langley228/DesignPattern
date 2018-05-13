﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.Cheeses
{
    public class MozzarellaCheese : ICheese
    {
        public string Name { get; } = "Mozzarella Cheese";
    }
}
