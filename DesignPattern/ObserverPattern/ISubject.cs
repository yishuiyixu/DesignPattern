using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    public interface ISubject
    {
        void Register(IObserver observer);

        void Unregister(IObserver observer);

        void NotifyObserver();
    }
}
