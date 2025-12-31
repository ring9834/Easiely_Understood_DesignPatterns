using InterpreterLibrary.SimpleExample.ConcreteInterpretors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample
{
    // Client code demonstrating the pattern
    class Program
    {
        static void Main()
        {
            // Create context and set variable values
            Context context = new Context();
            context.SetVariable("A", true);
            context.SetVariable("B", false);
            context.SetVariable("C", true);

            // Build expression tree for: (A AND B) OR (C AND NOT B)
            // This represents: (true AND false) OR (true AND NOT false)
            //               = false OR true
            //               = true

            IExpression a = new VariableExpression("A");
            IExpression b = new VariableExpression("B");
            IExpression c = new VariableExpression("C");

            // Create sub-expressions
            IExpression aAndB = new AndExpression(a, b);        // A AND B
            IExpression notB = new NotExpression(b);            // NOT B
            IExpression cAndNotB = new AndExpression(c, notB);  // C AND NOT B

            // Final expression
            IExpression finalExpression = new OrExpression(aAndB, cAndNotB);

            // Evaluate the expression
            bool result = finalExpression.Interpret(context);

            Console.WriteLine("Expression: (A AND B) OR (C AND NOT B)");
            Console.WriteLine($"A = {context.GetVariable("A")}");
            Console.WriteLine($"B = {context.GetVariable("B")}");
            Console.WriteLine($"C = {context.GetVariable("C")}");
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("\n--- Testing different values ---");

            // Change variables and re-evaluate
            context.SetVariable("A", true);
            context.SetVariable("B", true);
            context.SetVariable("C", false);

            result = finalExpression.Interpret(context);
            Console.WriteLine($"\nA = {context.GetVariable("A")}");
            Console.WriteLine($"B = {context.GetVariable("B")}");
            Console.WriteLine($"C = {context.GetVariable("C")}");
            Console.WriteLine($"Result: {result}");
        }
    }

    /* OUTPUT:
    Expression: (A AND B) OR (C AND NOT B)
    A = True
    B = False
    C = True
    Result: True

    --- Testing different values ---

    A = True
    B = True
    C = False
    Result: True
    */
}
