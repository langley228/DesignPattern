using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Weathers.Oop
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temp, _humidity;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            Display();
        }

        // 這個布告板只顯示溫度和濕度
        public void Display()
        {
            Console.WriteLine($"Current conditions：{_temp}℃ and {_humidity}% humidity");
        }
    }
}
