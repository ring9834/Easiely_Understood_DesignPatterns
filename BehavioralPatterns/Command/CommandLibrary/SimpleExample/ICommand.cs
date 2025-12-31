using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    // 1. Command Interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
