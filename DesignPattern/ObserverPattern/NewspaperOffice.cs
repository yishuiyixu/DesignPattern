using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    public class NewspaperOffice : ISubject
    {
        Dictionary<string, string> valuelist = new Dictionary<string, string>();

        IList<IObserver> observersList = new List<IObserver>();

        public NewspaperOffice()
        {
            valuelist.Add("Name", "Beata");
            valuelist.Add("Age", "32");
        }

        public void NotifyObserver()
        {
            foreach (Subscriber item in observersList)
            {
                item.Update(this, valuelist);
            }
        }

        public void ValueChanges() 
        {
            this.valuelist["Name"] = "Noya";
            NotifyObserver();
        }

        public void Register(IObserver observer)
        {
            if (!observersList.Contains(observer))
            {
                observersList.Add(observer);
            }
        }

        public void Unregister(IObserver observer)
        {
            if (observersList.Contains(observer))
            {
                observersList.Remove(observer);
            }
        }
    }
}
