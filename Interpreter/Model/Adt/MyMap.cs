using System.Collections.Generic;
using Interpreter.MyExceptions;


namespace Interpreter.Model.Adt
{
    class MyMap<V> : IMap<V>
    {
        private static int key = 0;
        private readonly Dictionary<int, V> map;
        public int Key => key;

        public MyMap()
        {
            map = new Dictionary<int, V>();
        }

        public void Add(V value)
        {
            key++;
            map.Remove(key);
            map.Add(key, value);
        }

        public void DeleteEntry(int key)
        {
            map.Remove(key);
        }

        public Dictionary<int, V>.ValueCollection GetValues()
        {
            return map.Values;
        }

        public V LookUp(int key)
        {
            if (map.TryGetValue(key, out V value))
            {
                return value;
            }
            throw new InvalidKeyException();
        }

        public override string ToString()
        {
            string s = "[\n";
            foreach (int key in map.Keys)
            {
                s += $"\t{key}->{LookUp(key)} ";
            }
            s += "]";
            return s;
        }
    }
}
