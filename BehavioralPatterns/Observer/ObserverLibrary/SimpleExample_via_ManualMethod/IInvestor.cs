using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_ManualMethod
{
    // 1. THE OBSERVER INTERFACE
    // Defines the method that the Subject will call to notify the observer.
    public interface IInvestor
    {
        void Update(string stockSymbol, double price);
    }
}
