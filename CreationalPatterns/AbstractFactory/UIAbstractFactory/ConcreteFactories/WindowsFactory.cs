using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractFactory;
using UIAbstractFactory.AbstractProducts;
using UIAbstractFactory.ConcreteProducts;

namespace UIAbstractFactory.ConcreteFactories
{
    // Step 4: Concrete factories for each family

    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
