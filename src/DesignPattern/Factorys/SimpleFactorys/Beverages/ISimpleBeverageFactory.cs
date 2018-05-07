using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Factorys.SimpleFactorys.Beverages
{
    public interface ISimpleBeverageFactory
    {
        IBeverageProvide CreateBeverage(string pBeverageType);
    }
}
