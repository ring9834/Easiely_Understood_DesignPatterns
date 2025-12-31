using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_ManualMethod
{
    // 5. THE CLIENT
    class Program
    {
        static void Main()
        {
            // Create the Subject (Stock)
            var apple = new TechStock("AAPL", 150.00);

            // Create Observers (Investors)
            var alice = new Investor("Alice");
            var bob = new Investor("Bob");

            // Subscribe observers to the subject
            apple.Attach(alice);
            apple.Attach(bob);

            // Change the state - This triggers the notification
            apple.Price = 155.50;

            // Unsubscribe one person
            apple.Detach(alice);

            // Change state again
            apple.Price = 160.00;
        }
    }
}
