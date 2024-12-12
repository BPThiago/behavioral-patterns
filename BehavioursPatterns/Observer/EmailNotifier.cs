using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Observer
{
    internal class EmailNotifier : IObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"Email: Your order is now {status}.");
        }
    }
}
