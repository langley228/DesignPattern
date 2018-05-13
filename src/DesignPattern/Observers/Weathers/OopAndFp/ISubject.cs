using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Weathers.OopAndFp
{
    public interface ISubject<TData>
    {
        // 訂閱
        void RegisterObserver(IObserver<TData> observer);

        // 取消訂閱
        void RemoveObserver(IObserver<TData> observer);
        // 狀態變化時，通知所有觀察者
        void NotifyObservers();
    }

    public interface IObserver<TData>
    {
        // 氣象之變化時，subject會把這些值更新給observers
        void Update(TData  data);
    }

    public interface IDisplayElement 
    {
        // 布告板顯示
        void Display();
    }
}
