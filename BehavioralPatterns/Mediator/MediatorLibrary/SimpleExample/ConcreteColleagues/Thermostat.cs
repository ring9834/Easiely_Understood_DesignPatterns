using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample.ConcreteColleagues
{
    public class Thermostat : SmartDevice
    {
        public Thermostat(ISmartHomeMediator mediator) : base(mediator) { }

        public void SetTemperature(int temp) =>
            Console.WriteLine($"Thermostat: Temperature set to {temp}°C");
    }
}
