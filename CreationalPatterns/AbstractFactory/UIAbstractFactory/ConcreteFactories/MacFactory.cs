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
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
