using System;
using System.Collections.Generic;

namespace Interpreter.View
{
    class TextMenu
    {
        private Dictionary<string, Command> commands;

        public TextMenu()
        {
            commands = new Dictionary<string, Command>();
        }
        public void AddCommand(Command c)
        {
            commands.Add(c.Key, c);
        }
        public void PrintMenu()
        {
            Console.WriteLine("\n\tMenu\n");
            foreach (Command com in commands.Values)
            {
                string line = string.Format("{0,4} :\n{1}\n",com.Key, com.Description);
                Console.WriteLine(line);
            }
        }

        public void Show()
        {
            while (true)
            {
                PrintMenu();
                Console.WriteLine("Input the option: ");
                string key = Console.ReadLine();
                if (!commands.TryGetValue(key, out Command com))
                {
                    Console.WriteLine("Invalid option");
                    continue;
                }
                com.Execute();
            }
        }
    }
}
