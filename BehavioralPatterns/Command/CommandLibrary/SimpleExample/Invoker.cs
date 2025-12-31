using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 6. Invoker (Remote Control with 7 slots and undo button)
    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (slot < 0 || slot >= 7) return;

            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            if (slot < 0 || slot >= 7) return;

            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            if (slot < 0 || slot >= 7) return;

            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            Console.WriteLine("--- UNDO BUTTON PRESSED ---");
            undoCommand.Undo();
        }

        public override string ToString()
        {
            string str = "\n------ Remote Control ------\n";
            for (int i = 0; i < onCommands.Length; i++)
            {
                str += $"[slot {i}] {onCommands[i].GetType().Name.PadRight(25)} {offCommands[i].GetType().Name}\n";
            }
            str += $"[undo] {undoCommand.GetType().Name}\n";
            return str;
        }
    }
}
