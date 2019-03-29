using System.IO;
using Interpreter.Model.Stmt;

namespace Interpreter.Model.Adt
{
    class PrgState
    {
        public IStack<IStmt> ExeStack { get; }
        public IDictionary<string, int> SymTable { get; }
        public IList<int> Output { get; }
        public IMap<ITuple<string, StreamReader>> FileTable { get; }
        public IStmt OriginalProgram { get; }

        public PrgState(IStack<IStmt> exeStack, IDictionary<string, int> symTable, IList<int> output, 
            IMap<ITuple<string, StreamReader>> fileTable, IStmt originalProgram)
        {
            ExeStack = exeStack;
            SymTable = symTable;
            Output = output;
            FileTable = fileTable;
            OriginalProgram = originalProgram;
            exeStack.Push(originalProgram);
        }

        public override string ToString()
        {
            return "\tProgram State\nExecution Stack\n" + ExeStack.ToString() +
                "\n\nTable of Symbols: " + SymTable.ToString() +
                "\n\nOutput: " + Output.ToString() +
                "\n\nFile Table: " + FileTable.ToString() +
                 "\n\n\n\n";
        }

    }
}
