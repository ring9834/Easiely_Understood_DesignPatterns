using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceLibrary.SimpleExample
{
    // 2. The Fluent Interface/Builder Class (The configurator)
    // All configuration methods return 'this' to allow chaining.
    public class CarConfigurator
    {
        private readonly Car _car = new Car();

        // Start of the chain (often the constructor or a static factory method)
        public CarConfigurator BuildModel(string model)
        {
            _car.Model = model;
            // The key to fluency: return the current instance.
            return this;
        }

        public CarConfigurator SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarConfigurator WithEnginePower(int hp)
        {
            _car.Horsepower = hp;
            return this;
        }

        // End of the chain: the method that materializes the result
        public Car Assemble()
        {
            Console.WriteLine($"Car assembly complete for: {_car.Model}");
            return _car;
        }
    }
}
