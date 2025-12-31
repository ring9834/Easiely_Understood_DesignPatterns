using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLibrary.SimpleExample
{
    // 2. Concrete Flyweight - holds intrinsic (shared) state
    public class TreeType : IVegetationType
    {
        private readonly string _name;      // e.g., "Pine"
        private readonly string _texture;   // e.g., "pine_texture.png"
        private readonly string _color;     // e.g., "dark green"

        public TreeType(string name, string texture, string color)
        {
            _name = name;
            _texture = texture;
            _color = color;
            Console.WriteLine($"Creating TreeType: {_name} (texture: {_texture})");
        }

        // Extrinsic state (x, y, scale) is passed in at runtime
        public void Display(int x, int y, double scale)
        {
            Console.WriteLine($"Rendering {_name} tree at ({x}, {y}) with scale {scale:F2} " +
                              $"(texture: {_texture}, color: {_color})");
        }
    }
}
