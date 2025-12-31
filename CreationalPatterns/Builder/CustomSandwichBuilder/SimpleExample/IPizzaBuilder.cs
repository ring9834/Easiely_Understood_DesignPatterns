using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSandwichBuilder.SimpleExample
{
    // Builder Interface
    public interface IPizzaBuilder
    {
        IPizzaBuilder SetSize(string size);
        IPizzaBuilder AddCheese();
        IPizzaBuilder AddPepperoni();
        IPizzaBuilder AddMushrooms();
        IPizzaBuilder AddBacon();
        IPizzaBuilder AddExtraTopping(string topping);
        Pizza Build();
        void Reset();
    }
}
