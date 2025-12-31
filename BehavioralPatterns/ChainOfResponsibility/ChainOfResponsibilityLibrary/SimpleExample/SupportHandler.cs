using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityLibrary.SimpleExample
{
    // 1. ABSTRACT HANDLER
    public abstract class SupportHandler
    {
        private SupportHandler _nextHandler;

        // Method to build the chain
        public SupportHandler SetNext(SupportHandler handler)
        {
            this._nextHandler = handler;
            return handler; // Return the handler to allow fluent chaining
        }

        // Abstract method for handling the request
        public virtual void HandleRequest(int level)
        {
            // If the request can't be handled here, pass it to the next handler
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(level);
            }
            else
            {
                // If it reaches the end of the chain
                Console.WriteLine($"\n[Request Level {level}]: Cannot be resolved. End of the support chain reached.");
            }
        }
    }
}
