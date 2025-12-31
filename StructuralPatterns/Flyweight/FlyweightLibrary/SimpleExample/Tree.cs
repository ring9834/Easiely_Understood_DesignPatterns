using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLibrary.SimpleExample
{
    // 4. Context class - holds extrinsic state and reference to flyweight
    public class Tree
    {
        private readonly int _x;
        private readonly int _y;
        private readonly double _scale;
        private readonly IVegetationType _treeType; // Reference to shared flyweight

        public Tree(int x, int y, double scale, IVegetationType treeType)
        {
            _x = x;
            _y = y;
            _scale = scale;
            _treeType = treeType;
        }

        public void Draw()
        {
            _treeType.Display(_x, _y, _scale);
        }
    }

}
