using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.SimpleExample
{
    // 2. CONTEXT (The object whose behavior changes based on its state)
    // The Context class holds an instance of a concrete state object and delegates all state-related behavior to it.
    public class TrafficLight
    {
        // The field that holds the current state
        private ITrafficLightState _currentState;

        public TrafficLight()
        {
            // Set the initial state
            SetState(new RedLightState());
        }

        // Allows states to change the context's state at runtime
        public void SetState(ITrafficLightState newState)
        {
            Console.WriteLine($"[TrafficLight]: Changing state to {newState.GetType().Name}");
            this._currentState = newState;
        }

        // Delegates the request to the current state object
        public void RequestChange()
        {
            this._currentState.Handle(this);
        }

        // Public method to check the current status
        public string GetCurrentStatus()
        {
            return _currentState.GetStatus();
        }
    }
}
