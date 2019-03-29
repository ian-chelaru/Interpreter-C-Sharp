using System;


namespace Interpreter.MyExceptions
{
    class InvalidKeyException : Exception
    {
        public InvalidKeyException()
        {
        }

        public InvalidKeyException(string message)
            : base(message)
        {
        }

        public InvalidKeyException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
