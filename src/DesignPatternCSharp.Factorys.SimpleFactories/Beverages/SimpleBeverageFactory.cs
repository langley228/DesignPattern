using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.SimpleFactories.Beverages
{
    public class SimpleBeverageFactory : ISimpleBeverageFactory
    {
        public IBeverageProvide CreateBeverage(string pBeverageType)
        {
            IBeverageProvide beverage;
            Assembly asmb = this.GetType().Assembly;
            beverage = asmb.CreateInstance(string.Format("{0}.Prodects.{1}", this.GetType().Namespace, pBeverageType)) as IBeverageProvide;
            return beverage;
            //if (pBeverageType == "GreenTea")
            //    return beverage = new Prodects.GreenTea();
            //if (pBeverageType == "BlackTea")
            //    return beverage = new Prodects.BlackTea();
            //else
            //    return null;
        }
    }
}
