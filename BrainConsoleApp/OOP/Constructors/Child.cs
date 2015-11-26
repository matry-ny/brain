
namespace BrainConsoleApp.OOP.Constructors
{
    public class Child : Parent
    {
        public Child(SurrogateConsole console) : base(console)
        {
            console.WriteLine(typeof(Child).Name);
        }
    }
}
