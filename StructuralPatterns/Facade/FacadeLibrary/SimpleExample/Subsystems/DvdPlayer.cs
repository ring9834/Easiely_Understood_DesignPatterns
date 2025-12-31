using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample.Subsystems
{
    public class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player: On");
        public void Off() => Console.WriteLine("DVD Player: Off");
        public void Play(string movie) => Console.WriteLine($"DVD Player: Playing \"{movie}\"");
        public void Stop() => Console.WriteLine("DVD Player: Stopped");
        public void Eject() => Console.WriteLine("DVD Player: Ejecting disc");
    }
}
