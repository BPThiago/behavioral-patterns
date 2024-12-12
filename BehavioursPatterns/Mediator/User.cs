using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Mediator
{
    internal class User
    {
        public string Name { get; private set; }
        private IMediator _mediator;

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.Add(this);
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}
