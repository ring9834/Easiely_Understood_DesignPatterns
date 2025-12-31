using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeLibrary.SimpleExample
{
    // Main program to demonstrate the pattern
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROTOTYPE PATTERN DEMONSTRATION ===\n");

            // Create original object
            var originalAddress = new Address("123 Main St", "New York", "10001");
            var originalHobbies = new List<string> { "Reading", "Gaming", "Hiking" };

            var originalPerson = new Person("John Doe", 30, originalAddress, originalHobbies);

            Console.WriteLine("ORIGINAL OBJECT:");
            originalPerson.Display();

            // Test Shallow Clone
            Console.WriteLine("\nSHALLOW CLONE:");
            var shallowClone = originalPerson.Clone();

            // Modify the clone
            shallowClone.Name = "Jane Smith";
            shallowClone.Age = 25;
            shallowClone.Address.Street = "456 Oak Ave"; // This affects original!
            shallowClone.Hobbies.Add("Swimming"); // This affects original!

            Console.WriteLine("\nAfter modifying shallow clone:");
            Console.WriteLine("Original:");
            originalPerson.Display();
            Console.WriteLine("Shallow Clone:");
            shallowClone.Display();

            // Test Deep Clone
            Console.WriteLine("\nDEEP CLONE:");
            var deepClone = originalPerson.DeepClone();

            // Modify the deep clone
            deepClone.Name = "Bob Johnson";
            deepClone.Age = 35;
            deepClone.Address.Street = "789 Pine Rd"; // Does NOT affect original
            deepClone.Hobbies.Add("Cycling"); // Does NOT affect original

            Console.WriteLine("\nAfter modifying deep clone:");
            Console.WriteLine("Original:");
            originalPerson.Display();
            Console.WriteLine("Deep Clone:");
            deepClone.Display();

            // Using Prototype Registry
            Console.WriteLine("\n=== USING PROTOTYPE REGISTRY ===");
        }
    }
}
