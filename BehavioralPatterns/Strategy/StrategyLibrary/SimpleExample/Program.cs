using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.SimpleExample
{
    public class Program
    {
        // The client chooses and swaps the strategy at runtime.
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Strategy Pattern Demo ---\n");

            // 1. Create a Context (the shopping cart)
            var cart = new ShoppingCart(150.75m);

            // 2. Select and inject the first strategy (Credit Card)
            var creditCardStrategy = new CreditCardPayment("1234567890123456", "Alice Smith");
            cart.SetPaymentStrategy(creditCardStrategy);
            cart.Checkout();

            Console.WriteLine("\n=============================\n");

            // 3. Select and inject a different strategy (PayPal)
            var payPalStrategy = new PayPalPayment("alice.smith@example.com");
            cart.SetPaymentStrategy(payPalStrategy);
            cart.Checkout();
        }
    }
}
