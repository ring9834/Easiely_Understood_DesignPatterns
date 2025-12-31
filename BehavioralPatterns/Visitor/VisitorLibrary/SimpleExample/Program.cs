using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLibrary.SimpleExample
{
    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection of shapes
            List<IShape> shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 8)
            };

            Console.WriteLine("=== Area Calculation ===");
            AreaCalculator areaCalculator = new AreaCalculator();
            foreach (var shape in shapes)
            {
                shape.Accept(areaCalculator);
            }
            Console.WriteLine($"\nTotal Area: {areaCalculator.TotalArea:F2}\n");

            Console.WriteLine("=== Drawing Shapes ===");
            ShapeDrawer drawer = new ShapeDrawer();
            foreach (var shape in shapes)
            {
                shape.Accept(drawer);
            }
        }
    }
}
