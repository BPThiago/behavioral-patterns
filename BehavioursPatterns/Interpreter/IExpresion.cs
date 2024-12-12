using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Interpreter
{
    internal interface IExpression
    {
        int Interpret();
    }
}
