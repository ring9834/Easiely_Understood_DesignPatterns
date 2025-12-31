using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeLibrary.SimpleSample
{
    // --- II. Details (Concrete Implementations) ---
    // These concrete types implement the abstraction.
    public class CreditCardCharger : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[Detail] Using Credit Card Charger: Processing {amount:C}");
        }
    }
}
