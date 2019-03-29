using Interpreter.Model.Stmt;
using Interpreter.Model.Expression;
using Interpreter.Model.Adt;
using Interpreter.MyRepository;
using Interpreter.MyController;
using System.IO;


namespace Interpreter.View
{
    class MainInterpreter
    {
        static void Main(string[] args)
        {
            IStmt ex1 = new CompStmt(new AssignStmt("a", new ArithExp(new ConstExp(1), new ConstExp(2), "+")),
                new IfStmt(new VarExp("a"), new PrintStmt(new VarExp("a")), new AssignStmt("b", new ConstExp(3))));
            PrgState prg1 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string,int>(), new MyList<int>(), 
                new MyMap<ITuple<string,StreamReader>>(), ex1);
            IRepository repo1 = new Repository("D:\\VSProjects\\Interpreter\\log1.txt");
            repo1.AddProgram(prg1);
            Controller ctr1 = new Controller(repo1);

            IStmt ex2 = new PrintStmt(new VarExp("a"));
            PrgState prg2 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex2);
            IRepository repo2 = new Repository("D:\\VSProjects\\Interpreter\\log2.txt");
            repo2.AddProgram(prg2);
            Controller ctr2 = new Controller(repo2);

            IStmt ex3 = new PrintStmt(new ArithExp(new ConstExp(1), new ConstExp(0), "/"));
            PrgState prg3 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex3);
            IRepository repo3 = new Repository("D:\\VSProjects\\Interpreter\\log3.txt");
            repo3.AddProgram(prg3);
            Controller ctr3 = new Controller(repo3);

            IStmt ex4 = new CompStmt(new OpenRFileStmt("var_f", "D:\\VSProjects\\Interpreter\\file1.txt"),
                new CompStmt(new ReadFileStmt(new VarExp("var_f"), "var_c"), new CompStmt(new PrintStmt(new VarExp(
                        "var_c")), new CompStmt(new IfStmt(new VarExp("var_c"),
                        new CompStmt(new ReadFileStmt(new VarExp("var_f"), "var_c"),
                                new PrintStmt(new VarExp("var_c"))), new PrintStmt(new ConstExp(0))),
                        new CloseRFileStmt(new VarExp("var_f"))))));
            PrgState prg4 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex4);
            IRepository repo4 = new Repository("D:\\VSProjects\\Interpreter\\log4.txt");
            repo4.AddProgram(prg4);
            Controller ctr4 = new Controller(repo4);

            IStmt ex5 = new CompStmt(new OpenRFileStmt("var_f", "D:\\VSProjects\\Interpreter\\file2.txt"),
                new CompStmt(new ReadFileStmt(new VarExp("var_f"), "var_c"), new CompStmt(new PrintStmt(new VarExp(
                        "var_c")), new CompStmt(new IfStmt(new VarExp("var_c"),
                        new CompStmt(new ReadFileStmt(new VarExp("var_f"), "var_c"),
                                new PrintStmt(new VarExp("var_c"))), new PrintStmt(new ConstExp(0))),
                        new CloseRFileStmt(new VarExp("var_f"))))));
            PrgState prg5 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex5);
            IRepository repo5 = new Repository("D:\\VSProjects\\Interpreter\\log5.txt");
            repo5.AddProgram(prg5);
            Controller ctr5 = new Controller(repo5);

            IStmt ex6 = new CompStmt(new OpenRFileStmt("var_f", "D:\\VSProjects\\Interpreter\\file1.txt"),
                new OpenRFileStmt("var_f", "D:\\VSProjects\\Interpreter\\file1.txt"));
            PrgState prg6 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex6);
            IRepository repo6 = new Repository("D:\\VSProjects\\Interpreter\\log6.txt");
            repo6.AddProgram(prg6);
            Controller ctr6 = new Controller(repo6);

            IStmt ex7 = new OpenRFileStmt("var_f", "D:\\VSProjects\\Interpreter\\file0.txt");
            PrgState prg7 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex7);
            IRepository repo7 = new Repository("D:\\VSProjects\\Interpreter\\log7.txt");
            repo7.AddProgram(prg7);
            Controller ctr7 = new Controller(repo7);

            IStmt ex8 = new ReadFileStmt(new ConstExp(1), "var_c");
            PrgState prg8 = new PrgState(new MyStack<IStmt>(), new MyDictionary<string, int>(), new MyList<int>(),
                new MyMap<ITuple<string, StreamReader>>(), ex8);
            IRepository repo8 = new Repository("D:\\VSProjects\\Interpreter\\log8.txt");
            repo8.AddProgram(prg8);
            Controller ctr8 = new Controller(repo8);



            TextMenu menu = new TextMenu();
            menu.AddCommand(new ExitCommand("0", "exit"));
            menu.AddCommand(new RunExample("1", ex1.ToString(), ctr1));
            menu.AddCommand(new RunExample("2", ex2.ToString(), ctr2));
            menu.AddCommand(new RunExample("3", ex3.ToString(), ctr3));
            menu.AddCommand(new RunExample("4", ex4.ToString(), ctr4));
            menu.AddCommand(new RunExample("5", ex5.ToString(), ctr5));
            menu.AddCommand(new RunExample("6", ex6.ToString(), ctr6));
            menu.AddCommand(new RunExample("7", ex7.ToString(), ctr7));
            menu.AddCommand(new RunExample("8", ex8.ToString(), ctr8));
            menu.Show();
        }
    }
}
