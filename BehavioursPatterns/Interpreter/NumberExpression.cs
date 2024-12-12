using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Interpreter
{
    internal class NumberExpression : IExpression
    {
        private int _num;

        public NumberExpression(int num)
        {
            _num = num;
        }

        public int Interpret()
        {
            return _num;
        }
    }
}
