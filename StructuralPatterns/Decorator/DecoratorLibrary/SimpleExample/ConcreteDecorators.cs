using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.SimpleExample
{
    // This Pattern allows you to add new behavior to an existing object dynamically without altering its structure.

    // Milk Decorator
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => base.GetDescription() + ", Milk";
        public override double GetCost() => base.GetCost() + 0.50;
    }

    // Sugar Decorator
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => base.GetDescription() + ", Sugar";
        public override double GetCost() => base.GetCost() + 0.20;
    }
}
