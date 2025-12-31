using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary.SimpleExample
{
    // 3. The "Adapter"
    // This class implements the target interface and wraps the Adaptee.
    public class LightningToUsbCAdapter : IPhoneCharger
    {
        private readonly UsbCCable _usbCCable;

        public LightningToUsbCAdapter(UsbCCable usbCCable)
        {
            _usbCCable = usbCCable;
        }

        public void ChargeWithLightning()
        {
            Console.WriteLine("Adapter converts Lightning request to USB-C...");
            _usbCCable.PluginUsbC();
        }
    }
}
