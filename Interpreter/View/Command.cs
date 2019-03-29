using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.View
{
    abstract class Command
    {
        public Command(string key, string description)
        {
            Key = key;
            Description = description;
        }
        public string Key { get; }
        public string Description { get; }
        public abstract void Execute();
    }
}
