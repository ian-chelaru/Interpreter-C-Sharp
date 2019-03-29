using Interpreter.Model.Adt;
using Interpreter.Model.Expression;

namespace Interpreter.Model.Stmt
{
    class IfStmt : IStmt
    {
        private readonly Exp exp;
        private readonly IStmt thenStmt;
        private readonly IStmt elseStmt;

        public IfStmt(Exp exp, IStmt thenStmt, IStmt elseStmt)
        {
            this.exp = exp;
            this.thenStmt = thenStmt;
            this.elseStmt = elseStmt;
        }
        public PrgState Execute(PrgState state)
        {
            IStack<IStmt> stk = state.ExeStack;
            if (exp.Eval(state.SymTable) != 0)
            {
                stk.Push(thenStmt);
            }
            else
            {
                stk.Push(elseStmt);
            }
            return state;
        }

        public override string ToString()
        {
            return $"(If {exp} then {thenStmt} else {elseStmt})";
        }
    }
}
