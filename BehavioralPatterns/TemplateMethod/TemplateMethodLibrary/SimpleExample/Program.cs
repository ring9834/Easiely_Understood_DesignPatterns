using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodLibrary.SimpleExample
{
    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Making Coffee ===");
            BeverageMaker coffee = new CoffeeMaker();
            coffee.MakeBeverage();

            Console.WriteLine("=== Making Tea ===");
            BeverageMaker tea = new TeaMaker();
            tea.MakeBeverage();

            Console.WriteLine("=== Making Hot Chocolate ===");
            BeverageMaker hotChocolate = new HotChocolateMaker();
            hotChocolate.MakeBeverage();
        }
    }
}
