using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents
{
    // ==========================================
    // 1. EVENT ARGS CLASS (Data container for notifications)
    // ==========================================
    // Custom EventArgs to pass weather data to observers
    public class WeatherChangedEventArgs : EventArgs
    {
        public string Location { get; }
        public double Temperature { get; }
        public double Humidity { get; }
        public double Pressure { get; }
        public DateTime Timestamp { get; }

        public WeatherChangedEventArgs(string location, double temperature, double humidity, double pressure)
        {
            Location = location;
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Timestamp:HH:mm:ss}] {Location}: {Temperature}°C, {Humidity}% humidity, {Pressure}hPa";
        }
    }
}
