

namespace Interpreter.Model.Adt
{
    interface ITuple<X,Y>
    {
        X First
        {
            get;
        }

        Y Second
        {
            get;
        }

    }
}
