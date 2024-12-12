using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Mediator
{
    internal class ChatMediator : IMediator
    {
        private List<User> _users = new List<User>();

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (User user in _users)
            {
                if (user != sender)
                {
                    Console.WriteLine($"{sender.Name} to {user.Name}: {message}");
                }
            }
        }
    }
}
