using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory.ConcreteProducts
{
    // MacOS concrete products
    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a button in MacOS style (rounded with pill shape)");
        public void OnClick() => Console.WriteLine("Mac button clicked!");
    }
}
