using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoLibrary.SimpleExample
{
    // DEMO CLASS
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Memento Pattern Demo ---");

            // 1. Setup the Originator and Caretaker
            var editor = new Editor();
            var history = new History();

            // 2. Initial state and first save
            editor.SetContent("First draft complete.");
            history.Push(editor.Save());

            // 3. Change state and second save
            editor.SetContent("Added second sentence and revised.");
            history.Push(editor.Save());

            // 4. Change state again (without saving this time)
            editor.SetContent("Made a mistake! Need to undo.");
            Console.WriteLine($"\n**Current state (mistake):** \"{editor.GetContent()}\"");

            // 5. UNDO (Restore to the last saved state)
            Console.WriteLine("\n--- Performing Undo ---");

            // Get the latest Memento from the history (the "Added second sentence" state)
            EditorMemento lastSavedState = history.Pop();

            if (lastSavedState != null)
            {
                // Restore the Originator (editor) using the Memento
                editor.Restore(lastSavedState);
                Console.WriteLine($"**State after first undo:** \"{editor.GetContent()}\"");
            }

            // 6. UNDO AGAIN (Restore to the first saved state)
            Console.WriteLine("\n--- Performing Second Undo ---");

            // Get the next Memento (the "First draft complete" state)
            EditorMemento initialSavedState = history.Pop();

            if (initialSavedState != null)
            {
                // Restore the Originator (editor) using the Memento
                editor.Restore(initialSavedState);
                Console.WriteLine($"**State after second undo:** \"{editor.GetContent()}\"");
            }
        }
    }

    /*
    --- Memento Pattern Demo ---
    Editor: Current content is set to: "First draft complete."
    Editor: Saving state...
    History: Pushed new Memento to history.
    Editor: Current content is set to: "Added second sentence and revised."
    Editor: Saving state...
    History: Pushed new Memento to history.
    Editor: Current content is set to: "Made a mistake! Need to undo."

    **Current state (mistake):** "Made a mistake! Need to undo."

    --- Performing Undo ---
    History: Popped Memento for undo.
    Editor: Restored state to: "Added second sentence and revised."
    **State after first undo:** "Added second sentence and revised."

    --- Performing Second Undo ---
    History: Popped Memento for undo.
    Editor: Restored state to: "First draft complete."
    **State after second undo:** "First draft complete."
    */
}
