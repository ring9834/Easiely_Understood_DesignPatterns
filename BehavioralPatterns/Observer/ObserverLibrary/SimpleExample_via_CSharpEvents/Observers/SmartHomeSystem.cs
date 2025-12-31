using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents.Observers
{
    public class SmartHomeSystem
    {
        public SmartHomeSystem(string homeName)
        {
            Console.WriteLine($"🏠 Smart Home System '{homeName}' initialized");
        }

        public void OnWeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            Console.WriteLine($"\n🏠 Smart Home Adjusting:");

            // Adjust thermostat based on temperature
            if (e.Temperature > 24)
            {
                Console.WriteLine($"   🔥 Setting AC to 22°C (outside: {e.Temperature:F1}°C)");
            }
            else if (e.Temperature < 18)
            {
                Console.WriteLine($"   ❄️ Setting heater to 21°C (outside: {e.Temperature:F1}°C)");
            }
            else
            {
                Console.WriteLine($"   ✅ Perfect temperature, HVAC system idle");
            }

            // Adjust blinds based on conditions
            if (e.Humidity > 70)
            {
                Console.WriteLine("   Closing windows - high humidity detected");
            }
        }
    }
}
