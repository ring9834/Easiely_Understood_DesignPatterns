using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents.Observers
{
    // ==========================================
    // 4. OBSERVER (SUBSCRIBER) CLASSES
    // ==========================================
    // These classes subscribe to the WeatherStation's events

    public class WeatherDisplay
    {
        private string _displayName;

        public WeatherDisplay(string name)
        {
            _displayName = name;
            Console.WriteLine($"📺 Weather Display '{_displayName}' created");
        }

        // ==========================================
        // EVENT HANDLER METHOD
        // ==========================================
        // This method matches the EventHandler<WeatherChangedEventArgs> delegate
        // It will be called when WeatherStation raises WeatherChanged event
        public void OnWeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            // The sender parameter is the WeatherStation that raised the event
            // e contains the weather data
            Console.WriteLine($"\n[{_displayName}] Weather Update Received:");
            Console.WriteLine($"   Location: {e.Location}");
            Console.WriteLine($"   Temperature: {e.Temperature:F1}°C");
            Console.WriteLine($"   Humidity: {e.Humidity:F1}%");
            Console.WriteLine($"   Pressure: {e.Pressure:F1}hPa");
            Console.WriteLine($"   Time: {e.Timestamp:HH:mm:ss}");
        }

        public void OnWeatherAlert(object sender, string alertMessage)
        {
            Console.WriteLine($"\n⚠️ [{_displayName}] ALERT: {alertMessage}");
        }
    }
}
