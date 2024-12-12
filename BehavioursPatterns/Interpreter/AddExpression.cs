using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Interpreter
{
    internal class AddExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
}
