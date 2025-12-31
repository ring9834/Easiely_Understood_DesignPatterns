using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.SimpleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Plain coffee
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost():0.00}");

            // 2. Add milk
            myCoffee = new MilkDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost():0.00}");

            // 3. Add sugar (now it has milk AND sugar)
            myCoffee = new SugarDecorator(myCoffee);
            Console.WriteLine($"{myCoffee.GetDescription()} | Cost: ${myCoffee.GetCost():0.00}");

            // Output:
            // Simple Coffee | Cost: $2.00
            // Simple Coffee, Milk | Cost: $2.50
            // Simple Coffee, Milk, Sugar | Cost: $2.70
        }
    }
}
