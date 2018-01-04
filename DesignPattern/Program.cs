using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.ObserverPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObserverPattern();
        }

        static void TestObserverPattern()
        {
            NewspaperOffice office = new NewspaperOffice();
            Subscriber observer = new Subscriber(office);
            office.ValueChanges();
        }
    }
}
