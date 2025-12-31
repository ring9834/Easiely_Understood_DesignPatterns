using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceLibrary.SimpleExample
{
    // 3. Demonstration of Fluent Usage
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Fluent Interface Demo ---");

            // Use the fluent API to configure and build the car.
            // The code reads almost like a sentence.
            Car mySedan = new CarConfigurator()
                .BuildModel("Sedan Z4")
                .SetColor("Midnight Blue")
                .WithEnginePower(220)
                .Assemble(); // Finalizing call

            Console.WriteLine($"\nConfigured Car 1: {mySedan}");

            // Example of a second, different car configuration
            Car myTruck = new CarConfigurator()
                .BuildModel("Truck XLT")
                .WithEnginePower(400) // Methods can be called in any order
                .SetColor("Crimson Red")
                .Assemble();

            Console.WriteLine($"\nConfigured Car 2: {myTruck}");
        }
    }
}
