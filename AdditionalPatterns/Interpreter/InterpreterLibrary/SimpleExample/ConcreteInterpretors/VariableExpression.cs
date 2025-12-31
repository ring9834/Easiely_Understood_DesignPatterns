using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample.ConcreteInterpretors
{
    // Terminal Expression: Represents a variable (leaf node)
    public class VariableExpression : IExpression
    {
        private string name;

        public VariableExpression(string name)
        {
            this.name = name;
        }

        public bool Interpret(Context context)
        {
            // Simply retrieves the variable's value from context
            return context.GetVariable(name);
        }
    }
}
