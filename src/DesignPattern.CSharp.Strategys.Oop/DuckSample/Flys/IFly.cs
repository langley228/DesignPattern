﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.Oop.DuckSample
{
    /// <summary>
    /// 這是一個飛行行為的介面，所有飛行行為的類別都應該實作它
    /// </summary>
    public interface IFly
    {
        /// <summary>
        /// 飛行的方式
        /// </summary>
        /// <remarks>所有繼承FlyBehavior的類別都應該實作此方法</remarks>
        void fly();
    }
}
