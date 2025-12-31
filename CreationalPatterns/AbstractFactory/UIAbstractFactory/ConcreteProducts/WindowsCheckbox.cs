using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory.ConcreteProducts
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering a checkbox in Windows style (square with tick)");
        public void Check(bool isChecked) => Console.WriteLine($"Windows checkbox {(isChecked ? "checked" : "unchecked")}");
    }
}
