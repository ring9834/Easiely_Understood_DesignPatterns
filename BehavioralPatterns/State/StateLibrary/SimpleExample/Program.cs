using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLibrary.SimpleExample
{
    public class Program
    {
        // The client creates the context and continuously requests state changes without knowing the transition logic.
        // The TrafficLight (Context) class never uses conditional statements to handle state logic or transitions.
        // The logic for what to do in a state and what the next state is is entirely contained
        // within the individual state classes (RedLightState, GreenLightState, etc.).
        // This makes adding a new state (like a blinking yellow light) simple, as you only create
        // a new state class without modifying existing code.
        public static void Main(string[] args)
        {
            Console.WriteLine("--- State Pattern Demo: Traffic Light Cycle ---");

            // 1. Create the Context (The Traffic Light)
            var trafficLight = new TrafficLight();

            Console.WriteLine($"Initial Status: {trafficLight.GetCurrentStatus()}\n");

            // 2. Loop through several state changes (cycles)
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Cycle Step {i + 1}:");
                trafficLight.RequestChange();
                Console.WriteLine($"  Current Status: {trafficLight.GetCurrentStatus()}\n");
            }
        }

        // The strength of the State Pattern is not that zero existing code changes, but that the changes are confined to the
        // low-level state classes that directly manage the sequence, protecting the high-level Context from being modified.
        // This makes the system far more stable and compliant with the Open/Closed Principle.
    }
}
