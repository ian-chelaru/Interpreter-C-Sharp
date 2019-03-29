using Interpreter.Model.Adt;
using Interpreter.Model.Expression;

namespace Interpreter.Model.Stmt
{
    class PrintStmt : IStmt
    {
        private readonly Exp exp;

        public PrintStmt(Exp exp)
        {
            this.exp = exp;
        }
        public PrgState Execute(PrgState state)
        {
            state.Output.Add(exp.Eval(state.SymTable));
            return state;
        }

        public override string ToString()
        {
            return $"print({exp})";
        }
    }
}
