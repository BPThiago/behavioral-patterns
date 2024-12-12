using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Observer
{
    internal class Order
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UpdateStatus(string status)
        {
            foreach (IObserver observer in observers) 
                observer.Update(status);
        }
    }
}
