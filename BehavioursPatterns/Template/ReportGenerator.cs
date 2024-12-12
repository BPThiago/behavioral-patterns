using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Template
{
    internal abstract class ReportGenerator
    {
        protected void GenerateHeader()
        {
            Console.WriteLine("Generating report header...");
        }

        protected abstract void Export();

        public void GenerateReport()
        {
            GenerateHeader();
            Export();
        }
    }
}
