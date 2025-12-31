using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory.AbstractFactory
{
    // Step 3: Define the Abstract Factory interface

    /// <summary>
    /// The Abstract Factory interface declares creation methods for each abstract product
    /// </summary>
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
