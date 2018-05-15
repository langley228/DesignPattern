using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Weathers.Weather0
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
}
