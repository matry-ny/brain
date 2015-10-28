using System;

namespace BrainConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var messagesClass = new Messages(); 
            string message = messagesClass.getHelloMessage();

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
