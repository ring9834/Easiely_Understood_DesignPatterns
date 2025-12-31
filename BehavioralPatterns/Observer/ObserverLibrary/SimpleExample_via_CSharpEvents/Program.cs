using ObserverLibrary.SimpleExample_via_CSharpEvents.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_CSharpEvents
{
    // 5. CLIENT CODE (Sets up the relationships)
    // ==========================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== WEATHER STATION WITH C# EVENTS (Observer Pattern) ===\n");

            // Create the subject (publisher)
            WeatherStation nycStation = new WeatherStation("New York City");

            Console.WriteLine("\n--- Creating Observers (Subscribers) ---");

            // Create observers (subscribers)
            WeatherDisplay publicDisplay = new WeatherDisplay("Times Square Display");
            MobileWeatherApp johnsApp = new MobileWeatherApp("John");
            MobileWeatherApp sarahsApp = new MobileWeatherApp("Sarah");
            AgricultureMonitoringSystem farmSystem = new AgricultureMonitoringSystem("Central Valley Farm");
            SmartHomeSystem smartHome = new SmartHomeSystem("Suburban Home");

            Console.WriteLine("\n--- Subscribing to Events ---");

            // ==========================================
            // SUBSCRIBING TO EVENTS: The += operator
            // ==========================================
            // This is how observers subscribe to the subject's events
            // Each += adds an event handler to the invocation list

            // Subscribe public display to both events
            nycStation.WeatherChanged += publicDisplay.OnWeatherChanged;
            nycStation.WeatherAlert += publicDisplay.OnWeatherAlert;
            Console.WriteLine("✓ Times Square Display subscribed to weather updates and alerts");

            // Subscribe mobile apps to weather changes
            nycStation.WeatherChanged += johnsApp.OnWeatherChanged;
            Console.WriteLine("✓ John's mobile app subscribed to weather updates");

            nycStation.WeatherChanged += sarahsApp.OnWeatherChanged;
            Console.WriteLine("✓ Sarah's mobile app subscribed to weather updates");

            // Subscribe agriculture system to both events
            nycStation.WeatherChanged += farmSystem.OnWeatherChanged;
            nycStation.WeatherAlert += farmSystem.OnWeatherAlert;
            Console.WriteLine("✓ Agriculture system subscribed to weather updates and alerts");

            // Subscribe smart home to weather changes
            nycStation.WeatherChanged += smartHome.OnWeatherChanged;
            Console.WriteLine("✓ Smart home system subscribed to weather updates");

            //Console.WriteLine($"\nTotal subscribers: {nycStation.WeatherChanged?.GetInvocationList().Length ?? 0}");

            // ==========================================
            // SIMULATING WEATHER CHANGES
            // ==========================================
            Console.WriteLine("\n\n--- Simulating Weather Changes (Event Triggers) ---");

            // First update - all subscribers will be notified via event
            Console.WriteLine("\n=== DAY 1, MORNING ===");
            nycStation.UpdateWeather();

            Thread.Sleep(1500);

            Console.WriteLine("\n=== DAY 1, AFTERNOON ===");
            nycStation.UpdateWeather();

            Thread.Sleep(1500);

            Console.WriteLine("\n=== DAY 1, EVENING ===");
            nycStation.UpdateWeather();

            // Manual weather setting
            Console.WriteLine("\n--- Manual Weather Setting ---");
            nycStation.SetWeather(-2.0, 75.0, 1020.0);  // Cold weather - will trigger freeze alert

            Thread.Sleep(1500);

            Console.WriteLine("\n=== DAY 2, MORNING ===");
            nycStation.UpdateWeather();

            Console.WriteLine("\n--- Unsubscribing John's App ---");
            // ==========================================
            // UNSUBSCRIBING FROM EVENTS: The -= operator
            // ==========================================
            nycStation.WeatherChanged -= johnsApp.OnWeatherChanged;
            Console.WriteLine("✗ John's mobile app unsubscribed from weather updates");

            //Console.WriteLine($"\nRemaining subscribers: {nycStation.WeatherChanged?.GetInvocationList().Length ?? 0}");

            Console.WriteLine("\n=== DAY 2, AFTERNOON (John won't receive this) ===");
            nycStation.SetWeather(38.0, 40.0, 1005.0);  // Hot weather - will trigger heat alert

            // Show weather history
            Console.WriteLine("\n--- Weather History ---");
            johnsApp.ShowWeatherHistory();
            sarahsApp.ShowWeatherHistory();

            // Display current status
            Console.WriteLine("\n--- Final Status ---");
            nycStation.DisplayCurrentWeather();

            // ==========================================
            // DEMONSTRATING EVENT KEY FEATURES
            // ==========================================
            Console.WriteLine("\n\n=== EVENT-BASED OBSERVER PATTERN FEATURES ===");

            Console.WriteLine("\n1. MULTICAST DELEGATE:");
            Console.WriteLine("   - One event can have multiple subscribers");
            Console.WriteLine("   - All subscribers are notified when event is raised");

            Console.WriteLine("\n2. ENCAPSULATION:");
            Console.WriteLine("   - Outside classes can only += or -=");
            Console.WriteLine("   - Cannot invoke event directly");
            // nycStation.WeatherChanged.Invoke(...); // This would cause compiler error!

            Console.WriteLine("\n3. THREAD SAFETY:");
            Console.WriteLine("   - Storing delegate reference prevents race conditions");
            Console.WriteLine("   - Null-conditional operator (?.) provides safety");

            Console.WriteLine("\n4. DECOUPLING:");
            Console.WriteLine("   - WeatherStation doesn't know about concrete observer types");
            Console.WriteLine("   - Only knows about EventHandler delegate");

            Console.WriteLine("\n=== SIMULATION COMPLETE ===");
        }
    }
}
