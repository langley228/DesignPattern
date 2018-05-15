using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Sigletons
{
    //率先實體化
    public sealed class SealedSingleton
    {
        private static readonly SealedSingleton instance = new SealedSingleton();
        private SealedSingleton() { }
        public static SealedSingleton GetInstance() => SealedSingleton.instance;
    }
}
