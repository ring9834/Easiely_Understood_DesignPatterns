using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    public class DessertOrderCommand : IOrderCommand
    {
        private Chef _chef;
        private string _dishName;

        public DessertOrderCommand(Chef chef, string dishName)
        {
            _chef = chef;
            _dishName = dishName;
        }

        public void Execute()
        {
            _chef.PrepareDessert(_dishName);
        }

        public void Undo()
        {
            _chef.CancelDish(_dishName + " (dessert)");
        }

        public string GetDescription()
        {
            return $"Dessert: {_dishName}";
        }
    }
}
