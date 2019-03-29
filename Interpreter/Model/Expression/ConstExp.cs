using Interpreter.Model.Adt;

namespace Interpreter.Model.Expression
{
    class ConstExp : Exp
    {
        private readonly int number;

        public ConstExp(int number)
        {
            this.number = number;
        }
        public override int Eval(IDictionary<string, int> tbl)
        {
            return number;
        }

        public override string ToString()
        {
            return $"{number}";
        }
    }
}
