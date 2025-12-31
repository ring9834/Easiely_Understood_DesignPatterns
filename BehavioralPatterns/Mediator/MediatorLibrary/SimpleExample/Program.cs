using MediatorLibrary.SimpleExample.ConcreteColleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample
{
    // 5. Client Code / Demo
    class Program
    {
        static void Main(string[] args)
        {
            // Create the mediator (hub)
            var hub = new SmartHomeHub();

            // Create devices and register them with the hub
            var livingRoomLight = new Light(hub, "Living Room");
            var thermostat = new Thermostat(hub);
            var musicPlayer = new MusicPlayer(hub);
            var security = new SecuritySystem(hub);

            hub.RegisterLight(livingRoomLight);
            hub.RegisterThermostat(thermostat);
            hub.RegisterMusicPlayer(musicPlayer);
            hub.RegisterSecuritySystem(security);

            Console.WriteLine("=== Smart Home Simulation ===\n");

            // User arrives home
            security.SetHomeMode();

            Console.WriteLine("\n--- Later: User leaves home ---\n");

            // User leaves
            security.SetAwayMode();

            Console.WriteLine("\n--- Night time ---\n");

            // Going to bed
            security.SetSleepMode();
        }
    }
}
