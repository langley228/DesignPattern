﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories.Clamses
{
    public class FreshClams : IClams
    {
        public string Name { get; } = "Fresh Clams";
    }
}
