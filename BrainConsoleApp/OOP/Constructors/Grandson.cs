namespace BrainConsoleApp.OOP.Constructors
{
    public class Grandson : Child
    {
        public Grandson(SurrogateConsole console) : base(console)
        {
            console.WriteLine(typeof(Grandson).Name);
        }
    }
}
