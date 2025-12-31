using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 4. No Command (Null Object Pattern for no command)
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command assigned");
        }

        public void Undo()
        {
            Console.WriteLine("No command to undo");
        }
    }
}
