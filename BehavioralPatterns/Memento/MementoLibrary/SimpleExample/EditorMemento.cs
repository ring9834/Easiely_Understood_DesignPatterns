using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoLibrary.SimpleExample
{
    // 1. MEMENTO (The State Holder)
    // Stores the internal state of the Originator object.
    public class EditorMemento
    {
        private readonly string _state;

        public EditorMemento(string state)
        {
            this._state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }
}
