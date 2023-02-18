using DesignPatterns.Observer.interfaces;

public class WeatherDataSubject
{

    private int temp;
    private int humidity;
    private int pressure;
    private Random randomInstance;
	private IList<IObserver> observers;

    public WeatherDataSubject()
	{
		this.randomInstance = new Random();
		this.observers = new List<IObserver>();
	}

	public void measurementChanged()
	{
		this.humidity = getHumidity();
		this.pressure = getPressure();
        this.temp = getTemperature();

		NotifyObserver();
	}

	private void NotifyObserver()
	{
		foreach(var observer in observers)
		{
			observer.update(this.temp, this.humidity, this.pressure);
		}
	}

	public void RegisterObserver(IObserver observer)
	{
		this.observers.Add(observer);
	}

	public void RemoveObserver(IObserver observer)
	{
		this.observers.Remove(observer);
	}

	private int getTemperature()
	{
		return this.randomInstance.Next(-10, 10);
	}

	private int getHumidity()
	{
		return this.randomInstance.Next(11, 21);
    }

	private int getPressure()
	{
        return this.randomInstance.Next(21, 31);
    }
}
