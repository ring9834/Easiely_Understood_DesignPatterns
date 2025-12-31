using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoLibrary.SimpleExample
{
    // 3. CARETAKER (The History Manager)
    // Keeps track of multiple Mementos (history).
    public class History
    {
        private readonly Stack<EditorMemento> _history = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            _history.Push(memento);
            Console.WriteLine("History: Pushed new Memento to history.");
        }

        public EditorMemento Pop()
        {
            if (_history.Count > 0)
            {
                Console.WriteLine("History: Popped Memento for undo.");
                return _history.Pop();
            }
            return null;
        }
    }
}
