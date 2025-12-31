using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory.ConcreteProducts
{
    // Step 2: Define concrete products for each family (Windows and MacOS)

    // Windows concrete products
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a button in Windows style (rectangular with shadow)");
        public void OnClick() => Console.WriteLine("Windows button clicked!");
    }
}
