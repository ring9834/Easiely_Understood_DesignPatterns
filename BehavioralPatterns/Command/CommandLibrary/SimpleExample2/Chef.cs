using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    // 2. Receiver (The Cook/Chef who actually prepares the food)
    public class Chef
    {
        private string _name;

        public Chef(string name)
        {
            _name = name;
            Console.WriteLine($"Chef {_name} is ready in the kitchen!");
        }

        public void PrepareStarter(string dishName)
        {
            Console.WriteLine($"[{_name}] Preparing starter: {dishName}");
        }

        public void PrepareMainCourse(string dishName)
        {
            Console.WriteLine($"[{_name}] Cooking main course: {dishName}");
        }

        public void PrepareDessert(string dishName)
        {
            Console.WriteLine($"[{_name}] Making dessert: {dishName}");
        }

        public void CancelDish(string dishName)
        {
            Console.WriteLine($"[{_name}] Cancelling preparation of: {dishName}");
        }
    }
}
