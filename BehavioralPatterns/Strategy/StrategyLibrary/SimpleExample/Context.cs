using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.SimpleExample
{
    // 3. CONTEXT (The core business class)
    // The Context class holds a reference to a Strategy object and interacts with the Strategy interface.
    // The client only interacts with the Context.
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;
        private readonly decimal _totalAmount;

        public ShoppingCart(decimal totalAmount)
        {
            _totalAmount = totalAmount;
        }

        // Method to set the strategy at runtime
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this._paymentStrategy = strategy;
            Console.WriteLine($"\n[Cart]: Payment method set to {strategy.GetType().Name}.");
        }

        // Method that executes the strategy
        public void Checkout()
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("[Cart]: Error: No payment strategy selected.");
                return;
            }

            Console.WriteLine($"[Cart]: Initiating checkout for total: {_totalAmount:C}");
            _paymentStrategy.Pay(_totalAmount);
            Console.WriteLine("[Cart]: Transaction completed.");
        }
    }
}
