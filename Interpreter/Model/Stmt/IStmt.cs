using Interpreter.Model.Adt;

namespace Interpreter.Model.Stmt
{
    interface IStmt
    {
        PrgState Execute(PrgState state);
    }
}
