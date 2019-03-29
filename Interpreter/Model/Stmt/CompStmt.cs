using Interpreter.Model.Adt;

namespace Interpreter.Model.Stmt
{
    class CompStmt : IStmt
    {
        private readonly IStmt firstStmt;
        private readonly IStmt secondStmt;

        public CompStmt(IStmt first, IStmt second)
        {
            firstStmt = first;
            secondStmt = second;
        }

        public PrgState Execute(PrgState state)
        {
            IStack<IStmt> stk = state.ExeStack;
            stk.Push(secondStmt);
            stk.Push(firstStmt);
            return state;
        }

        public override string ToString()
        {
            return $"{firstStmt};\n{secondStmt}";
        }
    }
}
