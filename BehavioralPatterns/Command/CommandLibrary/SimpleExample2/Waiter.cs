using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    // 4. Invoker (The Waiter who takes orders)
    public class Waiter
    {
        private List<IOrderCommand> _orders = new List<IOrderCommand>();
        private List<IOrderCommand> _orderHistory = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand order)
        {
            _orders.Add(order);
            Console.WriteLine($"Waiter: Added '{order.GetDescription()}' to order slip");
        }

        public void RemoveOrder(IOrderCommand order)
        {
            if (_orders.Remove(order))
            {
                Console.WriteLine($"Waiter: Removed '{order.GetDescription()}' from order slip");
            }
        }

        public void PlaceOrders()
        {
            Console.WriteLine("\nWaiter: Taking order slip to the kitchen...");

            if (_orders.Count == 0)
            {
                Console.WriteLine("Waiter: No orders to place!");
                return;
            }

            Console.WriteLine($"Waiter: Placing {_orders.Count} order(s):");

            foreach (var order in _orders)
            {
                order.Execute();
                _orderHistory.Add(order);
            }

            _orders.Clear();
            Console.WriteLine("Waiter: All orders have been placed with the kitchen!");
        }

        public void UndoLastOrder()
        {
            if (_orderHistory.Count > 0)
            {
                var lastOrder = _orderHistory[_orderHistory.Count - 1];
                Console.WriteLine($"\nWaiter: Customer wants to cancel: {lastOrder.GetDescription()}");
                lastOrder.Undo();
                _orderHistory.RemoveAt(_orderHistory.Count - 1);
            }
            else
            {
                Console.WriteLine("No orders to undo!");
            }
        }

        public void ShowOrderSlip()
        {
            Console.WriteLine("\n=== CURRENT ORDER SLIP ===");
            if (_orders.Count == 0)
            {
                Console.WriteLine("(Empty)");
            }
            else
            {
                foreach (var order in _orders)
                {
                    Console.WriteLine($"- {order.GetDescription()}");
                }
            }
            Console.WriteLine("=========================\n");
        }

        public void ShowOrderHistory()
        {
            Console.WriteLine("\n=== ORDER HISTORY ===");
            if (_orderHistory.Count == 0)
            {
                Console.WriteLine("(No orders placed yet)");
            }
            else
            {
                for (int i = 0; i < _orderHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_orderHistory[i].GetDescription()}");
                }
            }
            Console.WriteLine("=====================\n");
        }
    }
}
