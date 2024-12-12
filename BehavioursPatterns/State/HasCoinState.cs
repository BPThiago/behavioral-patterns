using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    internal class HasCoinState : IState
    {
        public void Handle(VendingMachine machine)
        {
            machine.SetState(new SoldState());
            Console.WriteLine("Product selected.");
        }
    }
}
