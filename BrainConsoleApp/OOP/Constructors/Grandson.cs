namespace BrainConsoleApp.OOP.Constructors
{
    public class Grandson : Child
    {
        public Grandson(SurrogateConsole console) : base(console)
        {
            Console.WriteLine(typeof(Grandson).Name);
        }

        public override void PrintMessage()
        {
            Console.WriteLine(typeof(Grandson).Name);
        }
    }
}
