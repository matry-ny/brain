using System;
using BrainConsoleApp.OOP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP
{
    [TestClass]
    public class VideoPortsCollectionExtensionsTests
    {
        [TestMethod]
        public void TestNotFoundPort()
        {
            var collection = new VideoPortsCollection(new VideoPort[0]);

            // act
            VideoPort found;
            var result = VideoPortsCollectionExtensions.TryGetPort(collection, "test", out found);

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PortIsFoundTest()
        {
            var port = new VideoPort { Name = "HDMI" };
            var port1 = new VideoPort { Name = "DVI" };
            var port2 = new VideoPort { Name = "VGA" };
            var collection = new VideoPortsCollection(new[] { port, port1, port2 });

            VideoPort found;
            var result = collection.TryGetPort(port1.Name, out found);

            Assert.IsTrue(result);
            Assert.AreEqual(port1, found);
        }
    }
}
