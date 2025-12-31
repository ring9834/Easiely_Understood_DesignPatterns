using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample
{
    // Abstract Expression: Base interface for all expressions
    public interface IExpression
    {
        bool Interpret(Context context);
    }
}
