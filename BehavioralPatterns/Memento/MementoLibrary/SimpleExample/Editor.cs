using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoLibrary.SimpleExample
{
    // 2. ORIGINATOR (The State Creator/Restorer)
    // The object whose state we want to save.
    public class Editor
    {
        private string _content = string.Empty;

        public void SetContent(string content)
        {
            _content = content;
            Console.WriteLine($"Editor: Current content is set to: \"{_content}\"");
        }

        public string GetContent()
        {
            return _content;
        }

        // Creates a Memento containing the current state
        public EditorMemento Save()
        {
            Console.WriteLine("Editor: Saving state...");
            return new EditorMemento(_content);
        }

        // Restores the Originator's state from a Memento
        public void Restore(EditorMemento memento)
        {
            _content = memento.GetState();
            Console.WriteLine($"Editor: Restored state to: \"{_content}\"");
        }
    }
}
