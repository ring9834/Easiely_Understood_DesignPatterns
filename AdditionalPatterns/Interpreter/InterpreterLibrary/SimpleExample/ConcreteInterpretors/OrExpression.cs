using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample.ConcreteInterpretors
{
    // Non-Terminal Expression: Represents OR operation
    public class OrExpression : IExpression
    {
        private IExpression left;
        private IExpression right;

        public OrExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public bool Interpret(Context context)
        {
            // Evaluates both expressions and returns their OR result
            return left.Interpret(context) || right.Interpret(context);
        }
    }
}
