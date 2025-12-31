using FacadeLibrary.SimpleExample.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary.SimpleExample
{
    // Facade class - provides simple interface
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amp;
        private readonly DvdPlayer _dvd;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amp, DvdPlayer dvd, Projector projector,
                                 TheaterLights lights, PopcornPopper popper)
        {
            _amp = amp;
            _dvd = dvd;
            _projector = projector;
            _lights = lights;
            _popper = popper;
        }

        // Simplified high-level operations
        public void WatchMovie(string movie)
        {
            Console.WriteLine($"=== Get ready to watch \"{movie}\" ===\n");

            _popper.On();
            _popper.Pop();

            _lights.Dim(10);

            _projector.On();
            _projector.WideScreenMode();

            _amp.On();
            _amp.SetVolume(5);
            _amp.SetDvdPlayer(_dvd);

            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("\n=== Shutting down the home theater ===\n");

            _popper.Off();

            _lights.On();

            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();

            _projector.Off();

            _amp.Off();
        }
    }
}
