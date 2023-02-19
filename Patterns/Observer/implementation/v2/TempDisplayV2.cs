using DesignPatterns.Observer.interfaces;
using DesignPatterns.Observer.interfaces.v1;

namespace DesignPatterns.Observer.implementation.v1
{
    public class TempDisplayV2 : IObserverV2, IDisplay
    {
     
        public TempDisplayV2(IObservable observable)
        {
            observable.RegisterObserver(this);
        }
        private int temp = 0;
        public void Display()
        {
            if (temp >= 0)
            {
                Console.WriteLine("Warmer Temperature");
            }
            else
            {
                Console.WriteLine("Cooler Temperature");
            }
        }

        public void update(IObservable observable)
        {
            if (observable.GetType() == typeof(WeatherDataSubjectV2))
            {
                var weatherDataSubject = (WeatherDataSubjectV2)(observable);

                this.temp = weatherDataSubject.getTemperature();
            
            }
            Display();

        }
    }
}
