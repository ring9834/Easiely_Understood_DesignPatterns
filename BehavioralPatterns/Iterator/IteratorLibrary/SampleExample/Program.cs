using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary.SampleExample
{
    // 5. Client Code
    class Program
    {
        static void Main(string[] args)
        {
            SongCollection playlist = new SongCollection();
            playlist.AddSong("Hotel California");
            playlist.AddSong("Bohemian Rhapsody");
            playlist.AddSong("Stairway to Heaven");

            IIterator iterator = playlist.CreateIterator();

            Console.WriteLine("Iterating through playlist:");
            while (iterator.HasNext())
            {
                string song = (string)iterator.Next();
                Console.WriteLine($"- {song}");
            }
        }
    }
}
