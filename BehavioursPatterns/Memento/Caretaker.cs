using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Memento
{
    internal class Caretaker
    {
        private PlayerMemento _memento;

        public void Save(PlayerMemento memento)
        {
            _memento = memento;
        }

        public void Restore(Player player)
        {
            player.RestoreState(_memento);
        }
    }
}
