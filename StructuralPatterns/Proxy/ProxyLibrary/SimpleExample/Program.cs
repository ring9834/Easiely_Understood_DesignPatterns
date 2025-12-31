using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyLibrary.SimpleExample
{
    // 4. Client Code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Attempt 1: Wrong Password ---");
            IBook book1 = new ProxyBook("Top Secret Diary", "wrong_pass");
            book1.DisplayContent();

            Console.WriteLine("\n--- Attempt 2: Correct Password ---");
            IBook book2 = new ProxyBook("Top Secret Diary", "Secret123");
            book2.DisplayContent();
        }
    }

    // provides a substitute or placeholder for another object. A proxy controls access to the original object,
    // allowing you to perform something either before or after the request reaches the original object
    // (such as logging, caching, or security checks).
}
