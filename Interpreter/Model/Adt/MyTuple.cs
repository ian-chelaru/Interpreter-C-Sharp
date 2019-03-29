

namespace Interpreter.Model.Adt
{
    class MyTuple<X,Y> : ITuple<X,Y>
    {
        public MyTuple(X x, Y y)
        {
            First = x;
            Second = y;
        }
        public X First
        {
            get;
        }

        public Y Second
        {
            get;
        }

        public override string ToString()
        {
            return $"({First}, {Second})" ;
        }
    }
}
