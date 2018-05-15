using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.SimpleFactories.Beverages
{
    public class BeverageStores
    {
        private ISimpleBeverageFactory _factory;

        public BeverageStores(ISimpleBeverageFactory pFactory)
        {
            _factory = pFactory;
        }

        public IBeverageProvide BeverageOrders(string pBeverageType)
        {
            IBeverageProvide beverage;
            beverage = _factory.CreateBeverage(pBeverageType);
            if (beverage != null)
            {
                beverage.AddMaterial(); // 加料
                beverage.Brew(); // 沖泡
                beverage.PouredCup(); // 裝杯
            }
            else
            {
                beverage = new Prodects.NoneTea();
            }
            return beverage;
        }
    }
}
