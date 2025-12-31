using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    // 3. Concrete Commands (Specific Orders/Dishes)

    public class StarterOrderCommand : IOrderCommand
    {
        private Chef _chef;
        private string _dishName;

        public StarterOrderCommand(Chef chef, string dishName)
        {
            _chef = chef;
            _dishName = dishName;
        }

        public void Execute()
        {
            _chef.PrepareStarter(_dishName);
        }

        public void Undo()
        {
            _chef.CancelDish(_dishName + " (starter)");
        }

        public string GetDescription()
        {
            return $"Starter: {_dishName}";
        }
    }
}
