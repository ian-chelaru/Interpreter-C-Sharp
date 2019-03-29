using Interpreter.Model.Adt;

namespace Interpreter.Model.Expression
{
    abstract class Exp
    {
        public abstract int Eval(IDictionary<string,int> tbl);
    }
}
