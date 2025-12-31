using MediatorLibrary.SimpleExample.ConcreteColleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample
{
    // 2. Concrete Mediator - Central hub that coordinates devices
    public class SmartHomeHub : ISmartHomeMediator
    {
        private Light _livingRoomLight;
        private Thermostat _thermostat;
        private MusicPlayer _musicPlayer;
        private SecuritySystem _securitySystem;

        // Devices register themselves with the hub
        public void RegisterLight(Light light) => _livingRoomLight = light;
        public void RegisterThermostat(Thermostat thermostat) => _thermostat = thermostat;
        public void RegisterMusicPlayer(MusicPlayer player) => _musicPlayer = player;
        public void RegisterSecuritySystem(SecuritySystem security) => _securitySystem = security;

        // Called when any device triggers an event
        public void Notify(object sender, string eventType)
        {
            Console.WriteLine($"Hub notified: {eventType} by {sender.GetType().Name}\n");

            if (eventType == "HomeMode")
            {
                _livingRoomLight?.TurnOn();
                _thermostat?.SetTemperature(22);
                _musicPlayer?.Play("Welcome Playlist");
            }
            else if (eventType == "AwayMode")
            {
                _livingRoomLight?.TurnOff();
                _thermostat?.SetTemperature(15);
                _musicPlayer?.Stop();
            }
            else if (eventType == "SleepMode")
            {
                _livingRoomLight?.TurnOff();
                _musicPlayer?.Stop();
                _thermostat?.SetTemperature(18);
            }
        }
    }
}
