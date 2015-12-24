using System.Collections.Generic;

namespace BrainConsoleApp
{
    public class SurrogateConsole
    {
        private readonly List<string> _strings = new List<string>(); 

        public string[] GetStrings()
        {
            return _strings.ToArray();
        }

        public void WriteLine(string line)
        {
            _strings.Add(line);
        }

        public void Clear()
        {
            _strings.Clear();
        }
    }
}
