using System.Collections.Generic;
using System.IO;
using Interpreter.Model.Adt;
using Interpreter.MyExceptions;

namespace Interpreter.Model.Stmt
{
    class OpenRFileStmt : IStmt
    {
        private readonly string varFileId;
        private readonly string fileName;

        public OpenRFileStmt(string var, string fileName)
        {
            varFileId = var;
            this.fileName = fileName;
        }

        public HashSet<string> GetFileNames(PrgState state)
        {
            HashSet<string> fileNames = new HashSet<string>();
            IMap<ITuple<string, StreamReader>> fileTable = state.FileTable;
            Dictionary<int, ITuple<string, StreamReader>>.ValueCollection values = fileTable.GetValues();
            foreach (ITuple<string, StreamReader> value in values)
            {
                fileNames.Add(value.First);
            }
            return fileNames;
        }

        public PrgState Execute(PrgState state)
        {
            HashSet<string> fileNames = GetFileNames(state);
            if (fileNames.Contains(fileName))
            {
                throw new FileAlreadyOpenedException();
            }
            StreamReader sr = new StreamReader(fileName);
            IMap<ITuple<string, StreamReader>> fileTable = state.FileTable;
            ITuple<string, StreamReader> tuple = new MyTuple<string, StreamReader>(fileName,sr);
            fileTable.Add(tuple);
            Adt.IDictionary<string, int> symTable = state.SymTable;
            symTable.Add(varFileId, fileTable.Key);
            return state;
        }

        public override string ToString()
        {
            return $"openRFile({varFileId}, \"{fileName}\")";
        }
    }
}
