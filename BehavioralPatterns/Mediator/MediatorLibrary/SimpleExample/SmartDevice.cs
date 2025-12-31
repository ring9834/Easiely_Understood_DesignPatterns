using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample
{
    // 3. Colleague base class (optional, but helps with common behavior)
    public abstract class SmartDevice
    {
        protected ISmartHomeMediator Mediator;

        protected SmartDevice(ISmartHomeMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
