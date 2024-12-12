using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    internal class CommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();
        private Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_commands.Count == 0)
                return;
            var command = _commands.Pop();
            command.Undo();
            _redoStack.Push(command);
        }

        public void Redo()
        {
            if (_redoStack.Count == 0)
                return;
            var command = _redoStack.Pop();
            command.Execute();
            _commands.Push(command);
        }
    }
}
