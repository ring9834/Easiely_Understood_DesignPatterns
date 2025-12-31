using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents.Observers
{
    public class MobileWeatherApp
    {
        private string _userName;
        private List<string> _weatherHistory = new List<string>();

        public MobileWeatherApp(string userName)
        {
            _userName = userName;
            Console.WriteLine($"📱 Mobile Weather App for '{_userName}' installed");
        }

        // Event handler for weather updates
        public void OnWeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            string summary = $"📱 {_userName}'s phone: {e.Temperature:F1}°C in {e.Location}";
            _weatherHistory.Add($"{e.Timestamp:HH:mm} - {e.Temperature:F1}°C");

            Console.WriteLine($"\n{summary}");

            // Show different messages based on temperature
            if (e.Temperature > 25)
            {
                Console.WriteLine("   ☀️ Perfect day for the beach!");
            }
            else if (e.Temperature < 10)
            {
                Console.WriteLine("   🧣 Bundle up, it's cold outside!");
            }
            else
            {
                Console.WriteLine("   😊 Pleasant weather today!");
            }
        }

        public void ShowWeatherHistory()
        {
            Console.WriteLine($"\n📜 {_userName}'s Weather History:");
            foreach (var entry in _weatherHistory)
            {
                Console.WriteLine($"   {entry}");
            }
        }
    }
}
