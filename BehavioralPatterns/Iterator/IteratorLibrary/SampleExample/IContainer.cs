using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary.SampleExample
{
    // 2. The Aggregate Interface
    public interface IContainer
    {
        IIterator CreateIterator();
    }
}
