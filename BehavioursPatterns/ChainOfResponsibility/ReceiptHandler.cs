using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.ChainOfResponsibility
{
    internal class ReceiptHandler : DocumentHandler
    {
        protected override Boolean CanHandle(String document)
        {
            return document.Contains("Receipt");
        }
    }
}
