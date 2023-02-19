using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.interfaces
{
    public interface IObservable
    {
        void NotifyObservers();
        void RegisterObserver(IObserverV2 observer);
        void RemoveObserver(IObserverV2 oserver);
    }
}
