using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLibrary.SimpleExample.ConcreteColleagues
{
    public class MusicPlayer : SmartDevice
    {
        public MusicPlayer(ISmartHomeMediator mediator) : base(mediator) { }

        public void Play(string playlist) =>
            Console.WriteLine($"Music Player: Playing '{playlist}'");

        public void Stop() =>
            Console.WriteLine("Music Player: Stopped");
    }
}
