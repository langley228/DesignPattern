using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Sigletons
{

    //雙重上鎖
    public class SingletonLock
    {
        private static SingletonLock instance;
        private static readonly object syncRoot = new object();
        private SingletonLock() { }
        public static SingletonLock GetInstance()
        {
            if (instance == null) //確保當前沒有這個物件存在
            {
                lock (syncRoot)//鎖住當前狀態
                {
                    if (instance == null)
                        instance = new SingletonLock();
                }
            }
            return instance;
        }
    }
}
