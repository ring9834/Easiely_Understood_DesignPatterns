using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_ManualMethod
{
    // 4. CONCRETE OBSERVERS
    public class Investor : IInvestor
    {
        public string Name { get; }

        public Investor(string name) => Name = name;

        public void Update(string stockSymbol, double price)
        {
            Console.WriteLine($"Notified {Name}: {stockSymbol} is now ${price}");
        }
    }
}
