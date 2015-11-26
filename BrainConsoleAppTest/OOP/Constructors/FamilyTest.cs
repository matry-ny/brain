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
            var console = new SurrogateConsole();

            // act
            var data = new Grandson(console);
            
            // assert
            var log = console.GetStrings();
            Assert.AreEqual(3, log.Length);

            Assert.AreEqual(typeof(Parent).Name, log[0]);
            Assert.AreEqual(typeof(Child).Name, log[1]);
            Assert.AreEqual(typeof(Grandson).Name, log[2]);
        }
    }
}
