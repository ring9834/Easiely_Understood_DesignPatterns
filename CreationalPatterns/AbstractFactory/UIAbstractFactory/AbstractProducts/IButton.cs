using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAbstractFactory.AbstractProducts
{
    // Step 1: Define abstract products (the interfaces for the objects we want to create)

    /// <summary>
    /// Abstract product A: Button
    /// </summary>
    public interface IButton
    {
        void Render();
        void OnClick();
    }
}
