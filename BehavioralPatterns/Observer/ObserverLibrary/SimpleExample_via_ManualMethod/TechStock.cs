using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_ManualMethod
{
    // 3. CONCRETE SUBJECT
    public class TechStock : Stock
    {
        public TechStock(string symbol, double price) : base(symbol, price) { }
    }
}
