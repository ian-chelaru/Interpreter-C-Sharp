using System.Collections.Generic;

namespace Interpreter.Model.Adt
{
    interface IMap<V>
    {
        int Key { get; }
        V LookUp(int key);
        void Add(V value);
        Dictionary<int, V>.ValueCollection GetValues();
        void DeleteEntry(int key);
    }
}
