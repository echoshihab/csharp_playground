using DesignPatterns.Observer.interfaces.v1;

namespace DesignPatterns.Observer.implementation.v1
{
    public class TempDisplay : IObserver, IDisplay
    {
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

        public void update(int temp, int humidity, int pressure)
        {
            this.temp = temp;
            _ = humidity;
            _ = pressure;

            Display();

        }
    }
}
