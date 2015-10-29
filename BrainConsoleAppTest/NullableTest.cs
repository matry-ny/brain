using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    [TestClass]
    public class NullableTest
    {
        [TestMethod]
        public void nullableIntPlaygroundTest()
        {
            int? nullable = default(int?);

            Assert.IsFalse(nullable.HasValue);
            Assert.AreEqual(null, nullable);
            Assert.IsNull(nullable);

            nullable = 0;
            Assert.IsTrue(nullable.HasValue);
            Assert.AreEqual(0, nullable);

            nullable += 1;
            Assert.AreEqual(1, nullable);
        }

        [TestMethod]
        public void nullableIntBoolTest()
        {
            int? nullable = default(int?);
            
            nullable += 2;
            Assert.IsNull(nullable);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void nullableOfTTest()
        {
            var a = default(Nullable<decimal>);
            var b = default(Nullable<decimal>);

            decimal c = a.Value + b.Value;
            Assert.Fail();
        }
    }
}
