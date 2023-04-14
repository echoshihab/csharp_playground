using DesignPatterns.Observer.implementation.v1;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// Represents a Observer Demo class.
    /// </summary>
    public static class ObserverDemo
    {
        /// <summary>
        /// Observer Push Implementation.
        /// </summary>
        public static void ObserverPushImplementation()
        {
            var weatherData = new WeatherDataSubject();
            var currentWeatherDisplay = new CurrentWeatherDisplay();
            var tempDisplay = new TempDisplay();
            int timerCounter = 0;
            int removeObserverCount = 0;

            weatherData.RegisterObserver(currentWeatherDisplay);
            weatherData.RegisterObserver(tempDisplay);

            var timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Start();
            timer.Elapsed += delegate (Object source, System.Timers.ElapsedEventArgs e)
            {
                if (++timerCounter > 2 && removeObserverCount == 0)
                {
                    Console.WriteLine("Removing Temp Observer");
                    weatherData.RemoveObserver(tempDisplay);
                    removeObserverCount++;
                };

                if (++timerCounter > 4)
                {
                    timer.Stop();
                }

                weatherData.measurementChanged();
            };
        }

        /// <summary>
        /// Represents a Observer Pull Implementation.
        /// </summary>
        public static void ObserverPullImplementation()
        {
            var weatherData = new WeatherDataSubjectV2();
            var currentWeatherDisplay = new CurrentWeatherDisplayV2(weatherData);
            var tempDisplay = new TempDisplayV2(weatherData);
            int timerCounter = 0;
            int removeObserverCount = 0;

            var timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.Start();
            timer.Elapsed += delegate (Object source, System.Timers.ElapsedEventArgs e)
            {
                if (++timerCounter > 2 && removeObserverCount == 0)
                {
                    Console.WriteLine("Removing Temp Observer");
                    weatherData.RemoveObserver(tempDisplay);
                    removeObserverCount++;
                };

                if (++timerCounter > 4)
                {
                    timer.Stop();
                }

                weatherData.measurementChanged();
            };
        }
    }
}
