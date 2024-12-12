using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    internal class DeleteTextCommand : ICommand
    {
        private TextEditor _editor;
        private int _numChars;
        private string _substring;

        public DeleteTextCommand(TextEditor editor, int numChars)
        {
            _editor = editor;
            _numChars = numChars;
            _substring = editor.Text[^numChars..];
        }

        public void Execute()
        {
            _editor.Erase(_numChars);
        }

        public void Undo()
        {
            _editor.Write(_substring);
        }
    }
}
