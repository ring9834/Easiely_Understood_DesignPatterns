using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLibrary.SimpleExample
{
    // 2. The Real Subject (The object being protected)
    public class RealBook : IBook
    {
        private string _title;

        public RealBook(string title)
        {
            _title = title;
            LoadFromDisk(); // Simulating a heavy operation
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading book: '{_title}' from disk...");
        }

        public void DisplayContent()
        {
            Console.WriteLine($"Displaying the secret contents of '{_title}'.");
        }
    }
}
