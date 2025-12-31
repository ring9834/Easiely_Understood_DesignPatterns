using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.SimpleExample
{
    using System;

    // 1. STATE INTERFACE
    public interface ITrafficLightState
    {
        // A reference to the context is needed to allow states to change the context's state.
        // This interface defines the contract for all concrete state classes and typically
        // includes methods for handling requests and changing the state of the Context.
        void Handle(TrafficLight context);
        string GetStatus();
    }
}
