using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAbstractFactory.AbstractProducts
{
    /// <summary>
    /// Abstract product B: Checkbox
    /// </summary>
    public interface ICheckbox
    {
        void Render();
        void Check(bool isChecked);
    }
}
