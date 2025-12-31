using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeLibrary.SimpleExample
{
    // Concrete prototype class
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; } // Reference type property
        public List<string> Hobbies { get; set; } // Collection property

        public Person(string name, int age, Address address, List<string> hobbies)
        {
            Name = name;
            Age = age;
            Address = address;
            Hobbies = hobbies;
        }

        // Shallow Clone - only copies value types and references
        public Person Clone()
        {
            Console.WriteLine("Creating shallow clone...");
            return (Person)this.MemberwiseClone();
        }

        // Deep Clone - creates completely independent copy
        public Person DeepClone()
        {
            Console.WriteLine("Creating deep clone...");

            // Clone value types
            var clonedPerson = (Person)this.MemberwiseClone();

            // Create new instances for reference types
            clonedPerson.Address = new Address(
                Address.Street,
                Address.City,
                Address.ZipCode);

            // Clone collections
            clonedPerson.Hobbies = new List<string>(Hobbies);

            return clonedPerson;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
            Console.WriteLine($"Address: {Address.Street}, {Address.City}, {Address.ZipCode}");
            Console.WriteLine($"Hobbies: {string.Join(", ", Hobbies)}");
            Console.WriteLine($"HashCode: {GetHashCode()}");
            Console.WriteLine($"Address HashCode: {Address.GetHashCode()}");
            Console.WriteLine($"Hobbies HashCode: {Hobbies.GetHashCode()}");
            Console.WriteLine(new string('-', 40));
        }
    }

    // Another class to demonstrate complex objects
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string city, string zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
