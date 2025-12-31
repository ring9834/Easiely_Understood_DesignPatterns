using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLibrary.SimpleExample
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan fan;
        private int previousSpeed;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            previousSpeed = fan.GetSpeed();
            fan.Off();
        }

        public void Undo()
        {
            if (previousSpeed == 0)
                fan.Off();
            else if (previousSpeed == 1)
                fan.Low();
            else if (previousSpeed == 2)
                fan.Medium();
            else if (previousSpeed == 3)
                fan.High();
        }
    }
}
