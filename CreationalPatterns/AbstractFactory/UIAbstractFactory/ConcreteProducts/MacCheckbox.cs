using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory.ConcreteProducts
{
    public class MacCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering a checkbox in MacOS style (circle with dot)");
        public void Check(bool isChecked) => Console.WriteLine($"Mac checkbox {(isChecked ? "checked" : "unchecked")}");
    }
}
