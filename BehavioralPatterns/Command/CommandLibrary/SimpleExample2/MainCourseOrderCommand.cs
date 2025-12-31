using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample2
{
    public class MainCourseOrderCommand : IOrderCommand
    {
        private Chef _chef;
        private string _dishName;

        public MainCourseOrderCommand(Chef chef, string dishName)
        {
            _chef = chef;
            _dishName = dishName;
        }

        public void Execute()
        {
            _chef.PrepareMainCourse(_dishName);
        }

        public void Undo()
        {
            _chef.CancelDish(_dishName + " (main course)");
        }

        public string GetDescription()
        {
            return $"Main Course: {_dishName}";
        }
    }
}
