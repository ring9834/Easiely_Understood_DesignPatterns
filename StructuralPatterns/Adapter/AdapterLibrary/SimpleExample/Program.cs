using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary.SimpleExample
{
    // 4. The Client
    class Program
    {
        static void Main()
        {
            // We have a USB-C cable...
            UsbCCable myUsbC = new UsbCCable();

            // But we need to charge an iPhone (which wants IPhoneCharger).
            // So we plug the USB-C cable into our Adapter.
            IPhoneCharger adapter = new LightningToUsbCAdapter(myUsbC);

            // The phone "thinks" it's using a Lightning charger.
            CaptureChargingProcess(adapter);
        }

        static void CaptureChargingProcess(IPhoneCharger charger)
        {
            charger.ChargeWithLightning();
        }
    }
}
