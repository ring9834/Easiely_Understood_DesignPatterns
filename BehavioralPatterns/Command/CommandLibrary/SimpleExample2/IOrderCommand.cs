using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    // 1. Command Interface (The Order Slip)
    public interface IOrderCommand
    {
        void Execute();
        void Undo();
        string GetDescription();
    }
}
