using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample.Subsystems
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projector: On");
        public void Off() => Console.WriteLine("Projector: Off");
        public void WideScreenMode() => Console.WriteLine("Projector: Wide screen mode (16:9)");
    }
}
