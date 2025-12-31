using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample.ConcreteInterpretors
{
    // Non-Terminal Expression: Represents NOT operation
    public class NotExpression : IExpression
    {
        private IExpression expression;

        public NotExpression(IExpression expression)
        {
            this.expression = expression;
        }

        public bool Interpret(Context context)
        {
            // Negates the expression result
            return !expression.Interpret(context);
        }
    }
}
