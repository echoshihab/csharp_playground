namespace DesignPatterns.Observer.interfaces
{
    public interface IObserverV2
    {
        /// <summary>
        /// Updates observers
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        void update(IObservable observable);
    }
}
