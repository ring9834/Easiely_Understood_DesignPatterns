using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample
{
    // 1. Mediator Interface
    public interface ISmartHomeMediator
    {
        void Notify(object sender, string eventType);
    }
}
