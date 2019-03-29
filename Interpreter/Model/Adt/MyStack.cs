using System.Collections.Generic;

namespace Interpreter.Model.Adt
{
    class MyStack<T> : IStack<T>
    {
        private Stack<T> stack;

        public MyStack()
        {
            stack = new Stack<T>();
        }
        public T Pop()
        {
            return stack.Pop();
        }

        public void Push(T v)
        {
            stack.Push(v);
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public override string ToString()
        {
            string s = "{\n";
            foreach (T stmt in stack)
            {
                s += stmt.ToString() + "\n";
            }
            s += "}";
            return s;
        }
    }
}
