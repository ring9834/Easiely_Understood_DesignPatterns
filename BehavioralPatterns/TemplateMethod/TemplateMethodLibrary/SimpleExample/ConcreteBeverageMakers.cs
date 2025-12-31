using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodLibrary.SimpleExample
{
    // Concrete class for making coffee
    public class CoffeeMaker : BeverageMaker
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee grounds...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }

        protected override bool CustomerWantsExtras()
        {
            return true;
        }

        protected override void AddExtras()
        {
            Console.WriteLine("Adding whipped cream on top!");
        }
    }

    // Concrete class for making tea
    public class TeaMaker : BeverageMaker
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping tea bag...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }

        // Not overriding CustomerWantsExtras, so it returns false by default
    }

    // Concrete class for making hot chocolate
    public class HotChocolateMaker : BeverageMaker
    {
        protected override void Brew()
        {
            Console.WriteLine("Mixing chocolate powder...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding marshmallows...");
        }

        protected override bool CustomerWantsExtras()
        {
            return true;
        }

        protected override void AddExtras()
        {
            Console.WriteLine("Sprinkling chocolate chips!");
        }
    }
}
