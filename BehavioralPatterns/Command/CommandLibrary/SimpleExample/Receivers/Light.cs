using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 2. Receiver Classes
    public class Light
    {
        private string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{location} light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{location} light is OFF");
        }
    }
}
