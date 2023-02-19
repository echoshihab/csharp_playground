using DesignPatterns.Observer.interfaces;

public class WeatherDataSubjectV2 : IObservable
{

    private int temp;
    private int humidity;
    private int pressure;
    private Random randomInstance;
	private IList<IObserverV2> observers;

    public WeatherDataSubjectV2()
	{
		this.randomInstance = new Random();
		this.observers = new List<IObserverV2>();
	}

	public void measurementChanged()
	{
		this.humidity = getHumidity();
		this.pressure = getPressure();
        this.temp = getTemperature();

		NotifyObservers();
	}

	public void NotifyObservers()
	{
		foreach(var observer in observers)
		{
			observer.update(this);
		}
	}

	public void RegisterObserver(IObserverV2 observer)
	{
		this.observers.Add(observer);
	}

	public void RemoveObserver(IObserverV2 observer)
	{
		this.observers.Remove(observer);
	}

	public int getTemperature()
	{
		return this.randomInstance.Next(-10, 10);
	}

    public int getHumidity()
	{
		return this.randomInstance.Next(11, 21);
    }

    public int getPressure()
	{
        return this.randomInstance.Next(21, 31);
    }
}
