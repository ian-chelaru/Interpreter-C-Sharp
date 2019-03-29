using System.IO;
using Interpreter.Model.Adt;
using Interpreter.Model.Expression;
using Interpreter.MyExceptions;

namespace Interpreter.Model.Stmt
{
    class CloseRFileStmt : IStmt
    {
        private readonly Exp exp;

        public CloseRFileStmt(Exp exp)
        {
            this.exp = exp;
        }
        public PrgState Execute(PrgState state)
        {
            IDictionary<string, int> symTable = state.SymTable;
            IMap<ITuple<string, StreamReader>> fileTable = state.FileTable;
            try
            {
                int fd = exp.Eval(symTable);
                StreamReader sr = fileTable.LookUp(fd).Second;
                sr.Close();
                fileTable.DeleteEntry(fd);
                return state;
            }
            catch (InvalidKeyException)
            {
                throw new FileDescriptorException();
            }
        }

        public override string ToString()
        {
            return $"closeRFile({exp})";
        }
    }
}
