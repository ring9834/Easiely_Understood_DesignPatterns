using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSandwichBuilder.SimpleExample
{
    // Concrete Builder
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public IPizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public IPizzaBuilder AddCheese()
        {
            _pizza.Cheese = true;
            return this;
        }

        public IPizzaBuilder AddPepperoni()
        {
            _pizza.Pepperoni = true;
            return this;
        }

        public IPizzaBuilder AddMushrooms()
        {
            _pizza.Mushrooms = true;
            return this;
        }

        public IPizzaBuilder AddBacon()
        {
            _pizza.Bacon = true;
            return this;
        }

        public IPizzaBuilder AddExtraTopping(string topping)
        {
            _pizza.ExtraToppings.Add(topping);
            return this;
        }

        public Pizza Build()
        {
            // Validation could be added here
            if (string.IsNullOrEmpty(_pizza.Size))
            {
                throw new InvalidOperationException("Pizza size must be set");
            }

            Pizza result = _pizza;
            Reset();
            return result;
        }

        public void Reset()
        {
            _pizza = new Pizza();
        }
    }
}
