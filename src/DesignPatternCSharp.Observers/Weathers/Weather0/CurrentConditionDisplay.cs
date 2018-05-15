using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Weathers.Weather0
{

    public class CurrentConditionDisplay : IObserver<ModelData>, IDisplayElement
    {
        private float _temp, _humidity;
        public CurrentConditionDisplay(ISubject<ModelData> weatherData)
        {
            weatherData.RegisterObserver(this);
        }
        public void Update(ModelData data)
        {
            _temp = data.Temp;
            _humidity = data.Humidity;
            Display();
        }
        // 這個布告板只顯示溫度和濕度
        public void Display()
        {
            Console.WriteLine($"Current conditions：{_temp}℃ and {_humidity}% humidity");
        }
    }
}
