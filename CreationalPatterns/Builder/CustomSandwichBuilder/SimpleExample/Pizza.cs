using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSandwichBuilder.SimpleExample
{
    // Product Class
    public class Pizza
    {
        public string Size { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushrooms { get; set; }
        public bool Bacon { get; set; }
        public List<string> ExtraToppings { get; set; } = new List<string>();

        public Pizza() { }

        public void Display()
        {
            Console.WriteLine($"Pizza Size: {Size}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Pepperoni: {Pepperoni}");
            Console.WriteLine($"Mushrooms: {Mushrooms}");
            Console.WriteLine($"Bacon: {Bacon}");

            if (ExtraToppings.Count > 0)
            {
                Console.WriteLine($"Extra Toppings: {string.Join(", ", ExtraToppings)}");
            }
            Console.WriteLine();
        }
    }
}
