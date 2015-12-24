
namespace BrainConsoleApp.OOP.Constructors
{
    public class Child : Parent
    {
        protected readonly SurrogateConsole _console;

        public Child(SurrogateConsole console) : base(console)
        {
            _console = console;
            console.WriteLine(typeof(Child).Name);
        }

        protected SurrogateConsole Console
        {
            get { return _console; }
        }

        public virtual void PrintMessage()
        {
            Console.WriteLine(typeof(Child).Name);
        }
    }
}
