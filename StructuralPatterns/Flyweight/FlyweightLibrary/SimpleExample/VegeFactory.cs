using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLibrary.SimpleExample
{
    // 3. Flyweight Factory - manages shared flyweights
    public class VegeFactory
    {
        private static readonly Dictionary<string, IVegetationType> _vegeTypes = new();

        public static IVegetationType GetVegeType(string name, string texture, string color)
        {
            string key = name; // Could combine more fields if needed

            if (!_vegeTypes.TryGetValue(key, out IVegetationType? treeType))
            {
                treeType = new TreeType(name, texture, color);
                _vegeTypes.Add(key, treeType);
            }
            else
            {
                Console.WriteLine($"Reusing existing TreeType: {name}");
            }

            return treeType;
        }

        public static int TreeTypeCount => _vegeTypes.Count;
    }
}
