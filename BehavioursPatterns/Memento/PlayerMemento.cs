using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    internal class PlayerMemento
    {
        public int Position { get; private set; }
        public int Health { get; private set; }

        public PlayerMemento(int position, int health)
        {
            Position = position;
            Health = health;
        }
    }
}
