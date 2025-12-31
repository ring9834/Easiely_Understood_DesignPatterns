using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityLibrary.SimpleExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Chain of Responsibility Pattern Demo ---\n");

            // 1. BUILD THE CHAIN
            // The handlers are linked together sequentially.
            SupportHandler level1 = new Level1Support();
            SupportHandler level2 = new Level2Support();
            SupportHandler management = new Management();

            // Level 1 passes to Level 2, which passes to Management (fluent interface usage)
            level1.SetNext(level2).SetNext(management);

            // 2. SEND REQUESTS

            // Request 1: Simple issue (handled by Level 1)
            int request1 = 1;
            Console.WriteLine($"Client: Sending Request Level {request1}...");
            level1.HandleRequest(request1);

            Console.WriteLine("\n---");

            // Request 2: Technical issue (handled by Level 2)
            int request2 = 2;
            Console.WriteLine($"Client: Sending Request Level {request2}...");
            level1.HandleRequest(request2);

            Console.WriteLine("\n---");

            // Request 3: Managerial issue (handled by Management)
            int request3 = 3;
            Console.WriteLine($"Client: Sending Request Level {request3}...");
            level1.HandleRequest(request3);

            Console.WriteLine("\n---");

            // Request 4: Unprecedented issue (reaches the end of the chain)
            int request4 = 5;
            Console.WriteLine($"Client: Sending Request Level {request4}...");
            level1.HandleRequest(request4);
        }
    }
}
