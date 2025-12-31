using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeLibrary.SimpleSample
{
    // --- III. High-Level Module (The Consumer) ---
    // This class depends *only* on the abstraction (IPaymentGateway).
    public class PaymentProcessor
    {
        private readonly IPaymentGateway _gateway;

        // Dependency is requested via the constructor (Constructor Injection)
        public PaymentProcessor(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public void HandleOrder(decimal total)
        {
            Console.WriteLine($"[High-Level] Payment Processor starting order for {total:C}");
            _gateway.ProcessPayment(total);
            Console.WriteLine("[High-Level] Order successfully processed.");
        }
    }
}
