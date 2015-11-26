using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainConsoleApp.OOP.ClassVsStruct;

namespace BrainConsoleAppTest.OOP.ClassVsStruct
{
    [TestClass]
    public class ClassVsStructTest
    {
        [TestMethod]
        public void DefaultValuesAreDifferent()
        {
            var classInstance = default(AClass);
            var structInstance = default(AStruct);

            Assert.IsNull(classInstance);
            Assert.IsNotNull(structInstance);
        }
        
        [TestMethod]
        public void ValuesPropertyUpdatesPerformDifferentlyAcrossInstancesTest()
        {
            var initial = "Initial";
            var updated = "Updated";

            var classInstance = new AClass {Name = initial};
            var structInstance = new AStruct {Name = initial};

            // first wave
            var enotherClassInstance = classInstance;
            var enotherStructInstance = structInstance;

            Assert.AreEqual(initial, enotherClassInstance.Name);
            Assert.AreEqual(initial, enotherStructInstance.Name);

            // update origins
            classInstance.Name = updated;
            structInstance.Name = updated;

            Assert.AreEqual(updated, enotherClassInstance.Name);

            Assert.AreEqual(initial, enotherStructInstance.Name);
            Assert.AreEqual(updated, structInstance.Name);
        }
        
        [TestMethod]
        public void AnotherValuePropagationExample()
        {
            var initial = "Initial";
            var updated = "Updated";

            var structInstance = new AStruct { Name = initial };
            var classInstance = new AClass
            {
                Name = initial,
                Value = structInstance
            };

            // update origins
            var anotherStructInstance = classInstance.Value;
            anotherStructInstance.Name = updated;
            classInstance.Value = anotherStructInstance;

            Assert.AreEqual(updated, classInstance.Value.Name);
        }
    }
}
