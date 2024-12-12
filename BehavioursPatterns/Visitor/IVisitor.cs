using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Visitor
{
    internal interface IVisitor
    {
        public void Visit(ElementA elemA);
        public void Visit(ElementB elemB);
    }
}
