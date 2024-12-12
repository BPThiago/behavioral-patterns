using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    internal class WriteTextCommand : ICommand
    {
        private TextEditor _editor;
        private string _text;

        public WriteTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute()
        {
            _editor.Write(_text);
        }

        public void Undo()
        {
            _editor.Erase(_text.Length);
        }
    }
}
