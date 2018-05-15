using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Observers.Weathers.OopAndFp
{
    public delegate void NotifyHandler(ModelData data);
    public class WeatherData : ISubject<ModelData>
    {
        private ModelData _data = new ModelData();

        private event NotifyHandler NotifyEvent;

        public WeatherData()
        {
        }
        public void NotifyObservers()
        {
            NotifyEvent(_data);
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _data.Temp = temp;
            _data.Humidity = humidity;
            _data.Pressure = pressure;
            MeasurementsChanged();
        }

        public void RegisterObserver(IObserver<ModelData> observer)
        {
            NotifyEvent += observer.Update;
        }

        public void RemoveObserver(IObserver<ModelData> observer)
        {
            NotifyEvent -= observer.Update;
        }
    }
}
