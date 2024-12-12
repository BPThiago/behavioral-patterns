using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.ChainOfResponsibility
{
    internal abstract class DocumentHandler
    {
        protected DocumentHandler _nextHandler;

        public DocumentHandler SetNext(DocumentHandler documentHandler)
        {
            _nextHandler = documentHandler;
            return documentHandler;
        }

        public void Handle(String document)
        {
            if (CanHandle(document))
            {
                Console.WriteLine($"Processing {document}...");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(document);
            }
            else
            {
                Console.WriteLine($"Cannot process {document}.");
            }
        }

        protected abstract Boolean CanHandle(String document);
    }
}
