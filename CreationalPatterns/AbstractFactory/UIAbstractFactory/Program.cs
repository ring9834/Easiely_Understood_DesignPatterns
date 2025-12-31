using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAbstractFactory.AbstractFactory;
using UIAbstractFactory.ConcreteFactories;

namespace UIAbstractFactory
{
    // Step 6: Demo / Usage

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Windows Theme ===\n");
            IGUIFactory windowsFactory = new WindowsFactory();
            Application windowsApp = new Application(windowsFactory);
            windowsApp.RenderUI();
            windowsApp.Interact();

            Console.WriteLine("\n=== MacOS Theme ===\n");
            IGUIFactory macFactory = new MacFactory();
            Application macApp = new Application(macFactory);
            macApp.RenderUI();
            macApp.Interact();
        }
    }
}
