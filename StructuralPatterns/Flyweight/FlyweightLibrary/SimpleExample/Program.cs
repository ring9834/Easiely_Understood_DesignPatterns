using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLibrary.SimpleExample
{
    // The name Flyweight comes from boxing weight classes, where "flyweight" is the lightest
    // category — the smallest, most lightweight fighters.
    // The design pattern borrows this metaphor to express its core goal:
    // Make objects as lightweight as possible by minimizing memory usage.
    // Authough, strawweight is indeed lighter than flyweight in modern combat sports!
    // (a relatively modern addition introduced in the 1980s, while flyweight has been around since the early 1900s (established in 1909))
    // However, even today, the name sticks because it's memorable, historically fitting, and the pattern's focus is on reducing weight through sharing,
    // not on being the absolute lightest possible.

    // 5. Client code / Demo
    class Program
    {
        static void Main(string[] args)
        {
            // Create many trees, but only a few unique types
            var trees = new List<Tree>();

            // Only two intrinsic types: Pine and Oak
            var pineType = VegeFactory.GetVegeType("Pine", "pine_texture.png", "dark green");
            var oakType = VegeFactory.GetVegeType("Oak", "oak_texture.png", "brown");

            // Reuse the same types many times
            trees.Add(new Tree(10, 20, 1.0, pineType));
            trees.Add(new Tree(15, 25, 1.2, pineType)); // Reuses pineType
            trees.Add(new Tree(30, 40, 0.8, oakType));
            trees.Add(new Tree(35, 45, 1.5, pineType)); // Reuses again
            trees.Add(new Tree(50, 60, 1.0, oakType));

            // Add another pine - factory will reuse existing one
            var anotherPine = VegeFactory.GetVegeType("Pine", "pine_texture.png", "dark green");

            trees.Add(new Tree(100, 100, 2.0, anotherPine));

            Console.WriteLine("\n--- Drawing all trees ---\n");

            foreach (var tree in trees)
            {
                tree.Draw();
            }

            Console.WriteLine($"\nTotal unique TreeType objects created: {VegeFactory.TreeTypeCount}");
        }
    }
}
