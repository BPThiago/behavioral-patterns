using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    internal class TextEditor
    {
        public string Text { get; private set; }

        public void Write(string text)
        {
            Text += text;
        }

        public void Erase(int chars)
        {
            Text = Text[..^chars];
        }
    }
}
