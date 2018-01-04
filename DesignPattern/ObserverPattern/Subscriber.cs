using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    public class Subscriber : IDisplayElement, IObserver
    {
        ISubject subject;
        public Subscriber(ISubject sub)
        {
            this.subject = sub;
            subject.Register(this);
        }

        public void Display(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

        public void Update(ISubject sub, object arg)
        {
            Dictionary<string,string> temp = arg as Dictionary<string, string>;
            Display(temp["Name"] + ":" + temp["Age"]);
        }
    }
}
