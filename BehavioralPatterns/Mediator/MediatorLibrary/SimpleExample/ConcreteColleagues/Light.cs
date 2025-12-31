using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample.ConcreteColleagues
{
    // 4. Concrete Colleagues - Devices that use the mediator
    public class Light : SmartDevice
    {
        public string Location { get; }

        public Light(ISmartHomeMediator mediator, string location) : base(mediator)
        {
            Location = location;
        }

        public void TurnOn() => Console.WriteLine($"{Location} Light: Turned ON");
        public void TurnOff() => Console.WriteLine($"{Location} Light: Turned OFF");
    }
}
