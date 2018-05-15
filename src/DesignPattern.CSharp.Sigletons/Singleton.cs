using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Sigletons
{
    //延遲延遲實體化
    public class Singleton
    {
        private static Singleton singleton;
        private Singleton() { }
        public static Singleton GetInstance() => singleton ?? (singleton = new Singleton());
    }
}
