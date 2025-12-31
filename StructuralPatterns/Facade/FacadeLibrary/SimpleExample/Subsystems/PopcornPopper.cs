using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample.Subsystems
{
    public class PopcornPopper
    {
        public void On() => Console.WriteLine("Popcorn Popper: On");
        public void Off() => Console.WriteLine("Popcorn Popper: Off");
        public void Pop() => Console.WriteLine("Popcorn Popper: Popping popcorn!");
    }
}
