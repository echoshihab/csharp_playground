// See https://aka.ms/new-console-template for more information
using DesignPatterns.Observer.implementation;
using DesignPatterns.Observer.implementation.v1;


// V1 implementation (push)
//Console.WriteLine("Hello, World!");


//var weatherData = new WeatherDataSubject();
//var currentWeatherDisplay =  new CurrentWeatherDisplay();
//var tempDisplay = new TempDisplay();
//int timerCounter = 0;
//int removeObserverCount = 0;

//weatherData.RegisterObserver(currentWeatherDisplay);
//weatherData.RegisterObserver(tempDisplay);

//var timer = new System.Timers.Timer();
//timer.Interval = 2000;
//timer.Start();
//timer.Elapsed += delegate(Object source, System.Timers.ElapsedEventArgs e)
//{

//    if(++timerCounter > 2 && removeObserverCount == 0)
//    {
//        Console.WriteLine("Removing Temp Observer");
//        weatherData.RemoveObserver(tempDisplay);
//        removeObserverCount++;
//    };

//    if(++timerCounter > 4)
//    {
//        timer.Stop();
        
//    }
//    weatherData.measurementChanged();
//};

// v2 implementation (pull)
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


Console.WriteLine("Press the Enter key to exit the program at any time... ");
Console.ReadLine();



