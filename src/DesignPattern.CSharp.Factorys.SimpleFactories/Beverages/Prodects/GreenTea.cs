﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.SimpleFactories.Beverages.Prodects
{
    public class GreenTea : IBeverageProvide
    {
        public void AddMaterial()
        {

        }

        public void Brew()
        {

        }

        public void PouredCup()
        {

        }
        public string DisplayName { get { return "綠茶"; } }
    }
}
