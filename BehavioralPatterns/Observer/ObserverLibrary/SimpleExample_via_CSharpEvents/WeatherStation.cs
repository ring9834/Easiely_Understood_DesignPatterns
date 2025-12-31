using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents
{
    // ==========================================
    // 2. SUBJECT (PUBLISHER) CLASS
    // ==========================================
    public class WeatherStation
    {
        private string _location;
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private Random _random = new Random();

        // ==========================================
        // THE KEY EVENT: Using C# event keyword
        // ==========================================
        // This is the core of the Observer pattern implementation
        // EventHandler<WeatherChangedEventArgs> is a delegate type
        public event EventHandler<WeatherChangedEventArgs> WeatherChanged;

        // Additional event for alerts (shows multiple events can be used)
        public event EventHandler<string> WeatherAlert;

        public WeatherStation(string location)
        {
            _location = location;
            _temperature = 20.0;
            _humidity = 50.0;
            _pressure = 1013.25;
            Console.WriteLine($"🌤️ Weather Station initialized at {location}");
            Console.WriteLine($"   Initial conditions: {_temperature}°C, {_humidity}% humidity, {_pressure}hPa\n");
        }

        // ==========================================
        // 3. METHOD TO RAISE THE EVENT (Protected virtual)
        // ==========================================
        // This is the standard pattern for raising events in C#
        protected virtual void OnWeatherChanged(WeatherChangedEventArgs e)
        {
            // Store reference to avoid race conditions
            EventHandler<WeatherChangedEventArgs> handler = WeatherChanged;

            if (handler != null)  // Check if there are any subscribers
            {
                Console.WriteLine($"📡 [{_location}] Broadcasting weather update to {handler.GetInvocationList().Length} subscriber(s)...");

                // This is where the notification happens!
                // All subscribed observers will have their methods called
                handler(this, e);
            }
            else
            {
                Console.WriteLine($"📡 [{_location}] No subscribers for weather updates");
            }
        }

        protected virtual void OnWeatherAlert(string message)
        {
            EventHandler<string> handler = WeatherAlert;
            handler?.Invoke(this, message);
        }

        // Method to update weather data and notify observers
        public void UpdateWeather()
        {
            // Simulate random weather changes
            _temperature += (_random.NextDouble() - 0.5) * 5;  // -2.5 to +2.5 change
            _humidity += (_random.NextDouble() - 0.5) * 10;    // -5 to +5 change
            _humidity = Math.Max(0, Math.Min(100, _humidity)); // Keep within 0-100%
            _pressure += (_random.NextDouble() - 0.5) * 10;    // -5 to +5 change

            Console.WriteLine($"\n🌀 [{_location}] Weather conditions changed:");
            Console.WriteLine($"   Temperature: {_temperature:F1}°C");
            Console.WriteLine($"   Humidity: {_humidity:F1}%");
            Console.WriteLine($"   Pressure: {_pressure:F1}hPa");

            // Create event args with new data
            var eventArgs = new WeatherChangedEventArgs(_location, _temperature, _humidity, _pressure);

            // Raise the event (notify all subscribers)
            OnWeatherChanged(eventArgs);

            // Check for alert conditions
            if (_temperature > 35)
            {
                OnWeatherAlert($"🚨 HEAT WARNING: Temperature reached {_temperature:F1}°C at {_location}");
            }
            else if (_temperature < 0)
            {
                OnWeatherAlert($"❄️ FREEZE WARNING: Temperature dropped to {_temperature:F1}°C at {_location}");
            }

            if (_humidity > 85)
            {
                OnWeatherAlert($"💧 HIGH HUMIDITY: {_humidity:F1}% at {_location}");
            }
        }

        // Method to simulate specific weather conditions
        public void SetWeather(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Console.WriteLine($"\n🔧 [{_location}] Manually setting weather:");
            Console.WriteLine($"   Temperature: {_temperature}°C");
            Console.WriteLine($"   Humidity: {_humidity}%");
            Console.WriteLine($"   Pressure: {_pressure}hPa");

            var eventArgs = new WeatherChangedEventArgs(_location, temperature, humidity, pressure);
            OnWeatherChanged(eventArgs);
        }

        public void DisplayCurrentWeather()
        {
            Console.WriteLine($"\n📊 [{_location}] Current Weather:");
            Console.WriteLine($"   Temperature: {_temperature:F1}°C");
            Console.WriteLine($"   Humidity: {_humidity:F1}%");
            Console.WriteLine($"   Pressure: {_pressure:F1}hPa");
            Console.WriteLine($"   Subscribers: {WeatherChanged?.GetInvocationList().Length ?? 0}");
        }
    }
}
