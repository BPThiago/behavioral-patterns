using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Mediator
{
    internal interface IMediator
    {
        public void SendMessage(String message, User sender);
        public void Add(User user);
    }
}
