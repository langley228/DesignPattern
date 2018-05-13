using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.SimpleFactories.Beverages.Prodects
{
    public class NoneTea : IBeverageProvide
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
        public string DisplayName { get { return "無法生產的飲料"; } }
    }
}
