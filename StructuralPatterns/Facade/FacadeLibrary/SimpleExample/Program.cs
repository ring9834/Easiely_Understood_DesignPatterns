using FacadeLibrary.SimpleExample.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample
{
    // Client code (simple and clean thanks to Facade)
    class Program
    {
        static void Main(string[] args)
        {
            // Create subsystem components
            var amp = new Amplifier();
            var dvd = new DvdPlayer();
            var projector = new Projector();
            var lights = new TheaterLights();
            var popper = new PopcornPopper();

            // Create the Facade
            var homeTheater = new HomeTheaterFacade(amp, dvd, projector, lights, popper);

            // Client uses simple interface - no knowledge of subsystem complexity
            homeTheater.WatchMovie("Inception");

            Console.WriteLine("\n... enjoying the movie ...\n");

            homeTheater.EndMovie();
        }
    }
}
