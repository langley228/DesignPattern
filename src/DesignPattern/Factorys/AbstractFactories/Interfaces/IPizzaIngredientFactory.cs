﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.AbstractFactories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClams CreateClams();
        ISauce CreateSauce();
    }
}
