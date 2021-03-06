﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Weathers.Weather0
{

    public interface IObserver<TData>
    {
        // 氣象之變化時，subject會把這些值更新給observers
        void Update(TData data);
    }
}
