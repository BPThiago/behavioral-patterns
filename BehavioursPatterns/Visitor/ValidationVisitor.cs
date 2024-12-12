using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Visitor
{
    internal class ValidationVisitor : IVisitor
    {
        public void Visit(ElementA elemA)
        {
            Console.WriteLine("Validating ElementA...");
        }

        public void Visit(ElementB elemB)
        {
            Console.WriteLine("Validating ElementB...");
        }
    }
}
