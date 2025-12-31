using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeLibrary.SimpleSample
{
    // --- I. Abstraction (The Interface) ---
    // This contract lives in your core business logic assembly.
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
