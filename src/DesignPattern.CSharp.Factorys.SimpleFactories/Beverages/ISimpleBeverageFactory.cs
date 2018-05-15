using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Factorys.SimpleFactories.Beverages
{
    public interface ISimpleBeverageFactory
    {
        IBeverageProvide CreateBeverage(string pBeverageType);
    }
}
