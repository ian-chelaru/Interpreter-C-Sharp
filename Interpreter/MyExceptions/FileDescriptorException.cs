using System;


namespace Interpreter.MyExceptions
{
    class FileDescriptorException : Exception
    {
        public FileDescriptorException()
        {
        }

        public FileDescriptorException(string message)
            : base(message)
        {
        }

        public FileDescriptorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
