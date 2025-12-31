using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLibrary.SimpleExample
{
    // 1. Flyweight interface

    // Using the interface is a good design practice for several important reasons:
    // Loose coupling – The Tree class and TreeFactory depend on the abstraction (IVegetationType), not the concrete class.
    // Extensibility – You can later add other flyweight classes (like BushType, FlowerType) that also implement IVegetationType without changing client code.
    // Testability – Easier to mock or substitute different implementations in unit tests.
    // Follows Dependency Inversion Principle (part of SOLID) – High-level modules depend on abstractions.
    public interface IVegetationType
    {
        void Display(int x, int y, double scale);
    }
}
