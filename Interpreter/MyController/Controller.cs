using System;
using Interpreter.MyRepository;
using Interpreter.Model.Adt;

namespace Interpreter.MyController
{
    class Controller
    {
        private readonly IRepository repo;

        public Controller(IRepository repo)
        {
            this.repo = repo;
        }

        public PrgState OneStep(PrgState state)
        {
            return state.ExeStack.Pop().Execute(state);
        }
        
        public void AllSteps()
        {
            PrgState program = repo.GetCurrentProgram();
            repo.LogPrgStateExec();
            while(!program.ExeStack.IsEmpty())
            {
                OneStep(program);
                repo.LogPrgStateExec();
            }
        }
    }
}
