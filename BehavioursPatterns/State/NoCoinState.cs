using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    internal class NoCoinState : IState
    {
        public void Handle(VendingMachine machine)
        {
            machine.SetState(new HasCoinState());
            Console.WriteLine("Coin inserted.");

        }
    }
}
