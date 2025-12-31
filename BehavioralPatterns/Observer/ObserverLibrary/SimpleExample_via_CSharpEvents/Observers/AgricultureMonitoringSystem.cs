using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents.Observers
{
    public class AgricultureMonitoringSystem
    {
        private double _optimalGrowthTemp = 22.0;
        private double _optimalHumidity = 60.0;

        public AgricultureMonitoringSystem(string farmName)
        {
            Console.WriteLine($"🌱 Agriculture Monitoring System for {farmName}");
        }

        public void OnWeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            Console.WriteLine($"\n🌾 Agriculture Analysis for {e.Location}:");

            double tempDiff = Math.Abs(e.Temperature - _optimalGrowthTemp);
            double humidityDiff = Math.Abs(e.Humidity - _optimalHumidity);

            if (tempDiff < 5 && humidityDiff < 20)
            {
                Console.WriteLine("   ✅ Conditions are optimal for crop growth");
            }
            else
            {
                Console.WriteLine("   ⚠️ Sub-optimal conditions detected");

                if (e.Temperature > _optimalGrowthTemp)
                    Console.WriteLine($"   Consider increasing irrigation (temp: {e.Temperature:F1}°C)");
                if (e.Humidity < _optimalHumidity)
                    Console.WriteLine($"   Humidity below optimal: {e.Humidity:F1}%");
            }

            // Calculate growing degree days (simplified)
            double baseTemp = 10.0;
            if (e.Temperature > baseTemp)
            {
                double gdd = e.Temperature - baseTemp;
                Console.WriteLine($"   Growing Degree Days today: {gdd:F1}");
            }
        }

        public void OnWeatherAlert(object sender, string alertMessage)
        {
            if (alertMessage.Contains("FREEZE") || alertMessage.Contains("HEAT"))
            {
                Console.WriteLine($"\n🚜 AGRICULTURE ALERT: {alertMessage}");
                Console.WriteLine("   Taking protective measures for crops...");
            }
        }
    }
}
