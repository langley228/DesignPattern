using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Observers.Weathers.OopAndFp
{
    public class Program
    {
        public static void Sample()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            weatherData.SetMeasurements(10, 20, 30);
            weatherData.SetMeasurements(14, 25, 36);
            weatherData.SetMeasurements(40, 50, 60);
            Console.ReadLine();
        }
    }
}
