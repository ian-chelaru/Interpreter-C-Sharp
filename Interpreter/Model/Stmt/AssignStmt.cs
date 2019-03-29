using Interpreter.Model.Expression;
using Interpreter.Model.Adt;

namespace Interpreter.Model.Stmt
{
    class AssignStmt : IStmt
    {
        private readonly string id;
        private readonly Exp exp;

        public AssignStmt(string id, Exp exp)
        {
            this.id = id;
            this.exp = exp;
        }

        public PrgState Execute(PrgState state)
        {
            IDictionary<string, int> symTbl = state.SymTable;
            symTbl.Add(id, exp.Eval(symTbl));
            return state;
        }

        public override string ToString()
        {
            return $"{id}={exp}";
        }
    }
}
