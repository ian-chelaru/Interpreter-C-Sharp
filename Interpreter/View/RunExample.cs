using System;
using System.IO;
using Interpreter.MyController;
using Interpreter.MyExceptions;

namespace Interpreter.View
{
    class RunExample : Command
    {
        private readonly Controller ctr;

        public RunExample(string key, string description, Controller ctr)
            : base(key,description)
        {
            this.ctr = ctr;
        }
        public override void Execute()
        {
            try
            {
                ctr.AllSteps();
            }
            catch (VariableNotDefinedException)
            {
                Console.WriteLine("VariableNotDefined");
            }
            catch (InvalidOperatorException)
            {
                Console.WriteLine("InvalidOperator");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by 0");
            }
            catch (FileDescriptorException)
            {
                Console.WriteLine("File descriptor not found");
            }
            catch (FileAlreadyOpenedException)
            {
                Console.WriteLine("FileAlreadyOpened");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Read file not found");
            }
        }
    }
}
