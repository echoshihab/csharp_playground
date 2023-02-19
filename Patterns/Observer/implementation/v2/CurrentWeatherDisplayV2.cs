using DesignPatterns.Observer.interfaces;
using DesignPatterns.Observer.interfaces.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.implementation.v1
{
    public class CurrentWeatherDisplayV2 : IObserverV2, IDisplay
    {
        private int temp = 0, humidity = 0, pressure = 0;

        public CurrentWeatherDisplayV2(IObservable observable)
        {
            observable.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current Temp: {temp}, Current Humidity: {humidity}, Current Pressure: {pressure}");
        }

        public void update(IObservable observable)
        {
            if(observable.GetType() == typeof(WeatherDataSubjectV2))
            {
                var weatherDataSubject = (WeatherDataSubjectV2)(observable);

                this.temp = weatherDataSubject.getTemperature();
                this.humidity = weatherDataSubject.getHumidity();
                this.pressure = weatherDataSubject.getPressure();

            }
            Display();
        }
    }
}
