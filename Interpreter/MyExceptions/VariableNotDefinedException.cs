using System;

namespace Interpreter.MyExceptions
{
    class VariableNotDefinedException : Exception
    {
        public VariableNotDefinedException()
        {
        }

        public VariableNotDefinedException(string message)
            : base(message)
        {
        }

        public VariableNotDefinedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
