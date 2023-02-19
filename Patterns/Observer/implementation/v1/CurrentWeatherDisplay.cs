using DesignPatterns.Observer.interfaces.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.implementation.v1
{
    public class CurrentWeatherDisplay : IObserver, IDisplay
    {
        private int temp = 0, humidity = 0, pressure = 0;
        public void Display()
        {
            Console.WriteLine($"Current Temp: {temp}, Current Humidity: {humidity}, Current Pressure: {pressure}");
        }

        public void update(int temp, int humidity, int pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
