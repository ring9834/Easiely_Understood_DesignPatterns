using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 5. Macro Command (Command that executes multiple commands)
    public class MacroCommand : ICommand
    {
        private List<ICommand> commands;

        public MacroCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            Console.WriteLine("=== Executing Macro ===");
            foreach (var command in commands)
            {
                command.Execute();
            }
            Console.WriteLine("=== Macro Complete ===\n");
        }

        public void Undo()
        {
            Console.WriteLine("=== Undoing Macro ===");
            // Undo in reverse order
            for (int i = commands.Count - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
            Console.WriteLine("=== Macro Undone ===\n");
        }
    }
}
