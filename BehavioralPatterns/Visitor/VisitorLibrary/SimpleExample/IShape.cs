using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorLibrary.SimpleExample
{
    // Element interface
    public interface IShape
    {
        void Accept(IShapeVisitor visitor);
    }
}
