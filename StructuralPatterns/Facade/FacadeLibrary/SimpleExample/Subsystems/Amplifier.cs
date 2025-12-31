using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample.Subsystems
{
    // Subsystem components (complex classes)

    public class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier: On");
        public void Off() => Console.WriteLine("Amplifier: Off");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier: Volume set to {level}");
        public void SetDvdPlayer(DvdPlayer dvd) => Console.WriteLine("Amplifier: Connected to DVD Player");
    }
}
