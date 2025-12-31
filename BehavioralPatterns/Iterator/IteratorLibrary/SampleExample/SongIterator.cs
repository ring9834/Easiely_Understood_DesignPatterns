using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary.SampleExample
{
    // 4. Concrete Iterator
    public class SongIterator : IIterator
    {
        // In the strict, classic version of the Iterator pattern, we use the concrete class (SongCollection) rather than
        // the interface (IContainer) for a very practical reason: The Iterator needs to see the data.
        private SongCollection _collection;
        private int _index = 0;

        public SongIterator(SongCollection collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _index < _collection.GetSongs().Count;
        }

        public object Next()
        {
            if (HasNext())
            {
                return _collection.GetSongs()[_index++];
            }
            return null;
        }
    }
}
