using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 7. Client - Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Home Automation Remote Control ===\n");

            // Create the remote control (Invoker)
            RemoteControl remote = new RemoteControl();

            // Create devices (Receivers)
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan livingRoomFan = new CeilingFan("Living Room");

            // Create commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanHighCommand fanHigh = new CeilingFanHighCommand(livingRoomFan);
            CeilingFanOffCommand fanOff = new CeilingFanOffCommand(livingRoomFan);

            // Create a macro command (Party Mode)
            List<ICommand> partyOnCommands = new List<ICommand>
            {
                livingRoomLightOn,
                kitchenLightOn,
                fanHigh
            };

            List<ICommand> partyOffCommands = new List<ICommand>
            {
                livingRoomLightOff,
                kitchenLightOff,
                fanOff
            };

            MacroCommand partyModeOn = new MacroCommand(partyOnCommands);
            MacroCommand partyModeOff = new MacroCommand(partyOffCommands);

            // Load commands into remote slots
            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, fanHigh, fanOff);
            remote.SetCommand(3, partyModeOn, partyModeOff);

            // Display remote configuration
            Console.WriteLine(remote);

            // Test the remote
            Console.WriteLine("=== Testing Remote Control ===\n");

            remote.OnButtonWasPressed(0);   // Living room light on
            remote.OffButtonWasPressed(0);  // Living room light off
            remote.UndoButtonWasPressed();   // Undo: living room light on

            Console.WriteLine();

            remote.OnButtonWasPressed(1);   // Kitchen light on
            remote.OnButtonWasPressed(2);   // Fan high
            remote.UndoButtonWasPressed();   // Undo: fan off

            Console.WriteLine();

            // Test macro command (Party Mode)
            Console.WriteLine("Activating PARTY MODE:");
            remote.OnButtonWasPressed(3);   // All devices on

            Console.WriteLine("Turning off PARTY MODE:");
            remote.OffButtonWasPressed(3);  // All devices off

            Console.WriteLine("Undo PARTY MODE off:");
            remote.UndoButtonWasPressed();   // All devices back on

            Console.WriteLine("\n=== Remote Control Final State ===");
            Console.WriteLine(remote);
        }
    }
}
