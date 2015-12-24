using BrainConsoleApp;
using BrainConsoleApp.OOP.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP.Constructors
{
    [TestClass]
    public class FamilyTest
    {
        [TestMethod]
        public void ConstructorsLoadingTest()
        {
            SurrogateConsole console = new SurrogateConsole();

            // act
            Grandson data = new Grandson(console);
            
            // assert
            string[] log = console.GetStrings();
            Assert.AreEqual(3, log.Length);

            Assert.AreEqual(typeof(Parent).Name, log[0]);
            Assert.AreEqual(typeof(Child).Name, log[1]);
            Assert.AreEqual(typeof(Grandson).Name, log[2]);
        }
        
        [TestMethod]
        public void PrintMessageTest()
        {
            SurrogateConsole console = new SurrogateConsole();

            // act
            Child data = new Grandson(console);
            console.Clear();;
            
            data.PrintMessage();
            
            // assert
            string[] log = console.GetStrings();
            Assert.AreEqual(1, log.Length);
            Assert.AreEqual(typeof(Grandson).Name, log[0]);

        }
    }
}
