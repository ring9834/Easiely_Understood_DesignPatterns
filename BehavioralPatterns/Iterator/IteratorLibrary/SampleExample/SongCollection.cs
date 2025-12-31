using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary.SampleExample
{
    // 3. Concrete Aggregate
    public class SongCollection : IContainer
    {
        private List<string> _songs = new List<string>();

        public void AddSong(string title) => _songs.Add(title);

        public List<string> GetSongs() => _songs;

        public IIterator CreateIterator()
        {
            return new SongIterator(this);
        }
    }
}
