using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample.Subsystems
{
    public class TheaterLights
    {
        public void Dim(int level) => Console.WriteLine($"Theater Lights: Dimmed to {level}%");
        public void On() => Console.WriteLine("Theater Lights: Full brightness");
    }
}
