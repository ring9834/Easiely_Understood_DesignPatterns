using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample.ConcreteColleagues
{
    public class SecuritySystem : SmartDevice
    {
        public SecuritySystem(ISmartHomeMediator mediator) : base(mediator) { }

        public void SetHomeMode()
        {
            Console.WriteLine("Security System: Switching to HOME mode");
            Mediator.Notify(this, "HomeMode");
        }

        public void SetAwayMode()
        {
            Console.WriteLine("Security System: Switching to AWAY mode");
            Mediator.Notify(this, "AwayMode");
        }

        public void SetSleepMode()
        {
            Console.WriteLine("Security System: Switching to SLEEP mode");
            Mediator.Notify(this, "SleepMode");
        }
    }
}
