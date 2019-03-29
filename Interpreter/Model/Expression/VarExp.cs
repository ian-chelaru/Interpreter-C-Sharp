using Interpreter.Model.Adt;

namespace Interpreter.Model.Expression
{
    class VarExp : Exp
    {
        private readonly string id;

        public VarExp(string id)
        {
            this.id = id;
        }
        public override int Eval(IDictionary<string, int> tbl)
        {
            return tbl.Lookup(id);
        }

        public override string ToString()
        {
            return id;
        }
    }
}
