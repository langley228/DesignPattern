using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Weathers.Oop
{
    public interface ISubject
    {
        // 訂閱
        void RegisterObserver(IObserver observer);

        // 取消訂閱
        void RemoveObserver(IObserver observer);

        // 狀態變化時，通知所有觀察者
        void NotifyObservers();
    }
    public interface IObserver
    {
        // 氣象之變化時，subject會把這些值更新給observers
        void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        // 布告板顯示
        void Display();
    }
}
