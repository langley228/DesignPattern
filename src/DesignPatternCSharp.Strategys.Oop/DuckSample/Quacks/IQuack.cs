using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 這是一個叫聲行為的介面，所有叫聲行為的類別都應該實作它
    /// </summary>
    public interface IQuack
    {
        /// <summary>
        /// 叫聲的方式
        /// </summary>
        /// <remarks>所有繼承IQuack的類別都應該實作此方法</remarks>
        void quack();
    }
}
