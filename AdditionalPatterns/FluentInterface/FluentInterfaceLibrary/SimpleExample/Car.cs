using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceLibrary.SimpleExample
{
    // 1. The Target Class (The product being built/configured)
    public class Car
    {
        public string Model { get; set; } = "Unknown";
        public string Color { get; set; } = "White";
        public int Horsepower { get; set; } = 0;

        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, HP: {Horsepower}";
        }
    }
}
