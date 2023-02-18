namespace DesignPatterns.Observer.interfaces
{
    public interface IObserver
    {
        /// <summary>
        /// Updates observers
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void update(int temp, int humidity, int pressure);
    }
}
