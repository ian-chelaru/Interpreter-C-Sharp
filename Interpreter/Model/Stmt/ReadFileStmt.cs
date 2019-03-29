using System.IO;
using Interpreter.Model.Adt;
using Interpreter.Model.Expression;
using Interpreter.MyExceptions;

namespace Interpreter.Model.Stmt
{
    class ReadFileStmt : IStmt
    {
        private readonly Exp exp;
        private readonly string varName;

        public ReadFileStmt(Exp exp, string varName)
        {
            this.exp = exp;
            this.varName = varName;
        }

        public PrgState Execute(PrgState state)
        {
            Adt.IDictionary<string, int> symTable = state.SymTable;
            IMap<ITuple<string, StreamReader>> fileTable = state.FileTable;
            int fd = exp.Eval(symTable);
            try
            {
                StreamReader sr = fileTable.LookUp(fd).Second;
                string line;
                line = sr.ReadLine();
                int number;
                if (line == null)
                {
                    number = 0;
                }
                else
                {
                    int.TryParse(line, out number);
                }
                symTable.Add(varName, number);
                return state;
            }
            catch (InvalidKeyException)
            {
                throw new FileDescriptorException();
            }
        }

        public override string ToString()
        {
            return $"readFile({exp}, {varName})";
        }
    }
}
