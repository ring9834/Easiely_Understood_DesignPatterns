using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodLibrary.SimpleExample
{
    // Abstract class defining the template method
    public abstract class BeverageMaker
    {
        // Template Method - defines the algorithm structure
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();

            // Optional hook method
            if (CustomerWantsExtras())
            {
                AddExtras();
            }

            Console.WriteLine("Your beverage is ready!\n");
        }

        // Concrete methods (same for all beverages)
        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }

        // Abstract methods (must be implemented by subclasses)
        protected abstract void Brew();
        protected abstract void AddCondiments();

        // Hook method (optional override)
        protected virtual bool CustomerWantsExtras()
        {
            return false;
        }

        protected virtual void AddExtras()
        {
            // Default implementation does nothing
        }
    }
}
