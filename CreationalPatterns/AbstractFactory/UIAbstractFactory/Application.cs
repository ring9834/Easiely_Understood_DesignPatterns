using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractFactory;
using UIAbstractFactory.AbstractProducts;

namespace UIAbstractFactory
{
    // Step 5: Client code - works only with abstractions

    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }

        public void Interact()
        {
            _button.OnClick();
            _checkbox.Check(true);
        }
    }
}
