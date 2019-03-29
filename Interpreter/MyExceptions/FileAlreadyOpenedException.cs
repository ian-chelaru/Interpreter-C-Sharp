using System;


namespace Interpreter.MyExceptions
{
    class FileAlreadyOpenedException : Exception
    {
        public FileAlreadyOpenedException()
        {
        }

        public FileAlreadyOpenedException(string message)
            : base(message)
        {
        }

        public FileAlreadyOpenedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
