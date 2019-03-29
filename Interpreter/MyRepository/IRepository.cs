using Interpreter.Model.Adt;

namespace Interpreter.MyRepository
{
    interface IRepository
    {
        PrgState GetCurrentProgram();
        void AddProgram(PrgState newProgram);
        void LogPrgStateExec();
    }
}
