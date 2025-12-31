using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSandwichBuilder.SimpleExample
{
    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Builder Pattern Demo ===\n");

            // Method 1: Using Builder directly (Fluent Interface)
            Console.WriteLine("1. Custom Pizza using Fluent Builder:");
            var builder = new PizzaBuilder();

            Pizza customPizza = builder
                .SetSize("Large")
                .AddCheese()
                .AddPepperoni()
                .AddBacon()
                .AddExtraTopping("Jalapenos")
                .AddExtraTopping("Onions")
                .Build();

            customPizza.Display();
        }
    }
}
