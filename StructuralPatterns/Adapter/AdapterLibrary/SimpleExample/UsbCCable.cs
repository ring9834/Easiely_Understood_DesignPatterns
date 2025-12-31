using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary.SimpleExample
{
    // 2. The "Adaptee" (Legacy/External Class)
    // This is the class that has the functionality we need, 
    // but its interface is incompatible.
    public class UsbCCable
    {
        public void PluginUsbC()
        {
            Console.WriteLine("Charging via USB-C cable...");
        }
    }
}
