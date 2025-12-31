using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary.SampleExample
{
    // 1. The Iterator Interface
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
