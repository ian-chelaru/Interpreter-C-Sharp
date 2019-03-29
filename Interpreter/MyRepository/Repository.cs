using Interpreter.Model.Adt;
using System.Collections.Generic;
using System.IO;

namespace Interpreter.MyRepository
{
    class Repository : IRepository
    {
        private List<PrgState> programs;
        private readonly string logFilePath;

        public Repository(string path)
        {
            programs = new List<PrgState>();
            logFilePath = path;
            if (File.Exists(logFilePath))
            {
                File.Delete(logFilePath);
            }
        }
        public void AddProgram(PrgState newProgram)
        {
            programs.Add(newProgram);
        }

        public PrgState GetCurrentProgram()
        {
            return programs[0];
        }

        public void LogPrgStateExec()
        {
            StreamWriter sw = new StreamWriter(logFilePath, true);
            sw.WriteLine(programs[0].ToString());
            sw.Close();
        }
    }
}
