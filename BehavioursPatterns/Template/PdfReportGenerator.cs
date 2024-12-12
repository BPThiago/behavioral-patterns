using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Template
{
    internal class PdfReportGenerator : ReportGenerator
    {
        protected override void Export()
        {
            Console.WriteLine("Exporting to PDF...");
        }
    }
}
