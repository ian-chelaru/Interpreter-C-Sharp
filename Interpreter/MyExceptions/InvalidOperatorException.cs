using System;

namespace Interpreter.MyExceptions
{
    class InvalidOperatorException : Exception
    {
        public InvalidOperatorException()
        {
        }

        public InvalidOperatorException(string message)
            : base(message)
        {
        }

        public InvalidOperatorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
