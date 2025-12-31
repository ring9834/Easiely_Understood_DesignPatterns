using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.SimpleExample
{
    // 3a. CONCRETE STATE 1: Red Light
    // These classes implement the ITrafficLightState interface. They define the behavior associated with a particular state
    // and contain the logic for transitioning to the next state.
    public class RedLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            // When handled, the red light changes to green.
            Console.WriteLine("  -> Red Light: STOP. Waiting for 3 seconds...");
            System.Threading.Thread.Sleep(500); // Simulate delay
            context.SetState(new GreenLightState());
        }

        public string GetStatus()
        {
            return "Red: STOP";
        }
    }

    // 3b. CONCRETE STATE 2: Green Light
    public class GreenLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            // When handled, the green light changes to yellow.
            Console.WriteLine("  -> Green Light: GO. Waiting for 5 seconds...");
            System.Threading.Thread.Sleep(500); // Simulate delay
            context.SetState(new YellowLightState());
        }

        public string GetStatus()
        {
            return "Green: GO";
        }
    }

    // 3c. CONCRETE STATE 3: Yellow Light
    public class YellowLightState : ITrafficLightState
    {
        public void Handle(TrafficLight context)
        {
            // When handled, the yellow light changes back to red.
            Console.WriteLine("  -> Yellow Light: Prepare to STOP. Waiting for 2 seconds...");
            System.Threading.Thread.Sleep(500); // Simulate delay
            context.SetState(new RedLightState());
        }

        public string GetStatus()
        {
            return "Yellow: CAUTION";
        }
    }
}
