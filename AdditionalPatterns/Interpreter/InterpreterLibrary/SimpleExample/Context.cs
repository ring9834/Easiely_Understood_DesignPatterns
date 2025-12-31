using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterLibrary.SimpleExample
{
    // Context: Holds variable values that expressions can reference
    public class Context
    {
        private Dictionary<string, bool> variables = new Dictionary<string, bool>();

        public void SetVariable(string name, bool value)
        {
            variables[name] = value;
        }

        public bool GetVariable(string name)
        {
            if (variables.ContainsKey(name))
                return variables[name];
            throw new Exception($"Variable '{name}' not found");
        }
    }
}
