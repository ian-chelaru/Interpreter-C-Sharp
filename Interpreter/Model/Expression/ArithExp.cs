using Interpreter.MyExceptions;

namespace Interpreter.Model.Expression
{
    class ArithExp : Exp
    {
        private readonly Exp exp1;
        private readonly Exp exp2;
        private readonly string op;

        public ArithExp(Exp exp1, Exp exp2, string op)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
            this.op = op;
        }
        public override int Eval(Adt.IDictionary<string, int> tbl)
        {
            switch(op)
            {
                case "+":
                    return exp1.Eval(tbl) + exp2.Eval(tbl);
                case "-":
                    return exp1.Eval(tbl) - exp2.Eval(tbl);
                case "*":
                    return exp1.Eval(tbl) * exp2.Eval(tbl);
                case "/":
                    return exp1.Eval(tbl) / exp2.Eval(tbl);
                default:
                    throw new InvalidOperatorException();
            }
        }

        public override string ToString()
        {
            return $"({exp1}{op}{exp2})";
        }
    }
}
