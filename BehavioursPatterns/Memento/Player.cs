using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    internal class Player
    {
        public int Position { get; set; }
        public int Health { get; set; }

        private int savedPosition;
        private int savedHealth;

        public PlayerMemento SaveState()
        {
            return new PlayerMemento(Position, Health);
        }

        public void RestoreState(PlayerMemento memento)
        {
            Position = memento.Position;
            Health = memento.Health;
        }
    }
}
