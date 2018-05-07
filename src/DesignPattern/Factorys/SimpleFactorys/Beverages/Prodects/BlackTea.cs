using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.SimpleFactorys.Beverages.Prodects
{
    public class BlackTea : IBeverageProvide
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
        public string DisplayName { get { return "紅茶"; } }
    }
}
