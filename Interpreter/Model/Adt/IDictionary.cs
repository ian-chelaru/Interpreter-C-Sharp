using System.Collections.Generic;

namespace Interpreter.Model.Adt
{
    interface IDictionary<K,V>
    {
        V Lookup(K key);
        void Add(K key, V value);
        Dictionary<K, V> Dictionary
        {
            get;
        }
    }
}
