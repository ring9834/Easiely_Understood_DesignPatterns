using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    public class CeilingFan
    {
        private string location;
        private int speed; // 0 = off, 1 = low, 2 = medium, 3 = high

        public CeilingFan(string location)
        {
            this.location = location;
            speed = 0;
        }

        public void Low()
        {
            speed = 1;
            Console.WriteLine($"{location} fan is on LOW speed");
        }

        public void Medium()
        {
            speed = 2;
            Console.WriteLine($"{location} fan is on MEDIUM speed");
        }

        public void High()
        {
            speed = 3;
            Console.WriteLine($"{location} fan is on HIGH speed");
        }

        public void Off()
        {
            speed = 0;
            Console.WriteLine($"{location} fan is OFF");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
