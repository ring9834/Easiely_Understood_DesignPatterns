using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    // 5. Client (Restaurant/Customer)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Restaurant Order System (Command Pattern) ===\n");

            // Create chefs (Receivers)
            var headChef = new Chef("Gordon");
            var pastryChef = new Chef("Julia");

            // Create waiter (Invoker)
            var waiter = new Waiter();

            // Create order commands (The slips of paper)
            var soupOrder = new StarterOrderCommand(headChef, "Tomato Soup");
            var saladOrder = new StarterOrderCommand(headChef, "Caesar Salad");
            var steakOrder = new MainCourseOrderCommand(headChef, "Filet Mignon");
            var pastaOrder = new MainCourseOrderCommand(headChef, "Fettuccine Alfredo");
            var cakeOrder = new DessertOrderCommand(pastryChef, "Chocolate Cake");
            var pieOrder = new DessertOrderCommand(pastryChef, "Apple Pie");

            // Customer places orders
            Console.WriteLine("\n--- Table 12 is ordering ---");
            waiter.TakeOrder(soupOrder);
            waiter.TakeOrder(steakOrder);
            waiter.TakeOrder(cakeOrder);

            waiter.ShowOrderSlip();

            // Customer changes their mind
            Console.WriteLine("\n--- Customer changes order ---");
            waiter.RemoveOrder(soupOrder);
            waiter.TakeOrder(saladOrder);

            waiter.ShowOrderSlip();

            // Waiter submits orders to kitchen
            waiter.PlaceOrders();

            // Another table orders
            Console.WriteLine("\n--- Table 7 is ordering ---");
            waiter.TakeOrder(pastaOrder);
            waiter.TakeOrder(pieOrder);

            waiter.ShowOrderSlip();
            waiter.PlaceOrders();

            // Show history
            waiter.ShowOrderHistory();

            // Customer wants to cancel last order
            waiter.UndoLastOrder();

            // Queue up orders for later
            Console.WriteLine("\n--- Preparing orders for later service ---");
            var futureOrders = new List<IOrderCommand>
        {
            new StarterOrderCommand(headChef, "Bruschetta"),
            new MainCourseOrderCommand(headChef, "Grilled Salmon"),
            new DessertOrderCommand(pastryChef, "Tiramisu")
        };

            Console.WriteLine("Orders queued for later. Can be saved to database, sent to different chef, etc.");

            // Demonstrate executing queued orders
            Console.WriteLine("\n--- Executing queued orders ---");
            foreach (var order in futureOrders)
            {
                order.Execute();
            }
        }
    }
}
