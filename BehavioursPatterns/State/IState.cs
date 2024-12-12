using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.State
{
    internal interface IState
    {
        public void Handle(VendingMachine machine);
    }
}
