using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLibrary.SimpleExample
{
    // Concrete Visitor for calculating area
    public class AreaCalculator : IShapeVisitor
    {
        public double TotalArea { get; private set; }

        public void Visit(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            Console.WriteLine($"Circle area: {area:F2}");
            TotalArea += area;
        }

        public void Visit(Rectangle rectangle)
        {
            double area = rectangle.Width * rectangle.Height;
            Console.WriteLine($"Rectangle area: {area:F2}");
            TotalArea += area;
        }

        public void Visit(Triangle triangle)
        {
            double area = 0.5 * triangle.Base * triangle.Height;
            Console.WriteLine($"Triangle area: {area:F2}");
            TotalArea += area;
        }
    }

    // Concrete Visitor for drawing shapes
    public class ShapeDrawer : IShapeVisitor
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine($"Drawing a circle with radius {circle.Radius}");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine($"Drawing a rectangle {rectangle.Width}x{rectangle.Height}");
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine($"Drawing a triangle with base {triangle.Base} and height {triangle.Height}");
        }
    }
}
