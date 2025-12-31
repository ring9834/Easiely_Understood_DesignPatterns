using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.SimpleExample
{
    // 2a. CONCRETE STRATEGY 1: Credit Card Payment
    // These classes implement the IPaymentStrategy interface, providing different algorithms for the common task.
    public class CreditCardPayment : IPaymentStrategy
    {
        private readonly string _cardNumber;
        private readonly string _name;

        public CreditCardPayment(string cardNumber, string name)
        {
            _cardNumber = cardNumber;
            _name = name;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Credit Card]: Paid {amount:C} using card ending in {_cardNumber.Substring(_cardNumber.Length - 4)} by {_name}.");
            // In a real app, this would contain complex credit card processing logic.
        }
    }

    // 2b. CONCRETE STRATEGY 2: PayPal Payment
    public class PayPalPayment : IPaymentStrategy
    {
        private readonly string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"[PayPal]: Paid {amount:C} to {_email}'s account.");
            // In a real app, this would contain PayPal API integration logic.
        }
    }
}
