using System;
using System.Collections.Generic;
using Interpreter.MyExceptions;

namespace Interpreter.Model.Adt
{
    class MyDictionary<K, V> : IDictionary<K, V>
    {
        public MyDictionary()
        {
            Dictionary = new Dictionary<K, V>();
        }

        public Dictionary<K, V> Dictionary { get; }
        public void Add(K key, V value)
        {
            Dictionary.Remove(key);
            Dictionary.Add(key, value);
        }

        public V Lookup(K key)
        {
            if (Dictionary.TryGetValue(key, out V value))
            {
                return value;
            }
            throw new VariableNotDefinedException();
        }

        public override string ToString()
        {
            string s = "[";
            foreach (K key in Dictionary.Keys)
            {
                s += $"\t{key}->{Lookup(key)} ";
            }
            s += "]";
            return s;
        }
    }
}
