

namespace Interpreter.Model.Adt
{
    interface IStack<T>
    {
        T Pop();
        void Push(T v);
        bool IsEmpty();
    }
}
