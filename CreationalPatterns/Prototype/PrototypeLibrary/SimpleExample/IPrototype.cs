using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeLibrary.SimpleExample
{
    // The Prototype interface declares the Clone method
    public interface IPrototype<T>
    {
        T Clone();
        T DeepClone();
    }
}
