using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityLibrary.SimpleExample
{
    // 2a. CONCRETE HANDLER 1: Level 1 Support
    public class Level1Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 1)
            {
                Console.WriteLine($"[Level 1 Support]: Successfully handled request level {level}. Simple issue resolved.");
            }
            else
            {
                Console.WriteLine($"[Level 1 Support]: Cannot handle level {level}. Escalating...");
                base.HandleRequest(level);
            }
        }
    }

    // 2b. CONCRETE HANDLER 2: Level 2 Support
    public class Level2Support : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 2)
            {
                Console.WriteLine($"[Level 2 Support]: Successfully handled request level {level}. Requires technical expertise.");
            }
            else
            {
                Console.WriteLine($"[Level 2 Support]: Cannot handle level {level}. Escalating...");
                base.HandleRequest(level);
            }
        }
    }

    // 2c. CONCRETE HANDLER 3: Management
    public class Management : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 3)
            {
                Console.WriteLine($"[Management]: Successfully handled request level {level}. Requires high-level decision or resource allocation.");
            }
            else
            {
                Console.WriteLine($"[Management]: Cannot handle level {level}. This is an unprecedented issue!");
                base.HandleRequest(level);
            }
        }
    }
}
