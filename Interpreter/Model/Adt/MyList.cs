using System.Collections.Generic;

namespace Interpreter.Model.Adt
{
    class MyList<E> : IList<E>
    {
        private List<E> list;

        public MyList()
        {
            list = new List<E>();
        }
        public void Add(E e)
        {
            list.Add(e);
        }

        public override string ToString()
        {
            string s = "[ ";
            foreach (E e in list)
            {
                s += $"{e} ";
            }
            s += "]";
            return s;
        }
    }
}
