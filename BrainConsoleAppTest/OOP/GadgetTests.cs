﻿using System;
using BrainConsoleApp.OOP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest.OOP
{
    [TestClass]
    public class GadgetTests
    {
        [TestMethod]
        public void TestTitleAccessors()
        {
            Gadget testGadget = new Gadget();
            string expectedTitle = "Qwerty";
            testGadget.Title = expectedTitle;
            
            // assert
            Assert.AreEqual(testGadget.Title, expectedTitle);
        }
        
        [TestMethod]
        public void TestModelAccessors()
        {
            string expectedModel = "TE123R";
            Gadget testGadget = new Gadget(expectedModel, new VideoPort[0]);
            
            // assert
            Assert.AreEqual(testGadget.GetModel(), expectedModel);
        }

        [TestMethod]
        public void TestGetDescription()
        {
            string title = "MSI";
            string model = "CX70 2PF";

            Gadget testGadget = new Gadget(model, new VideoPort[0]);
            testGadget.Title = title;

            string expectedFormat = "Gadget: {0}, model: {1}";
            string result = testGadget.GetDescription(expectedFormat);
            string expectedResult = String.Format(expectedFormat, title, model);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestGetDescriptionOverloading()
        {
            string title = "LG";
            string model = "G3S";

            Gadget testGadget = new Gadget(model, new VideoPort[0]);
            testGadget.Title = title;

            string expectedFormat = Gadget.DescriptionFormat;
            string result = testGadget.GetDescription();
            string expectedResult = String.Format(expectedFormat, title, model);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TestVideoPorts()
        {
            string title = "Samsung";
            string model = "Galaxy S5";

            var port1 = new VideoPort {Name = "VGA"};
            var port2 = new VideoPort {Name = "HDMI"};
            var port3 = new VideoPort {Name = "DVI"};

            Gadget testGadget = new Gadget(model, new[] {port1, port2, port3});

            Assert.AreEqual(testGadget.VideoPorts.Count, 3);
            Assert.AreEqual(testGadget.VideoPorts[0], port1);
            Assert.AreEqual(testGadget.VideoPorts[1], port2);
            Assert.AreEqual(testGadget.VideoPorts[2], port3);
        }

        [TestMethod]
        public void TestVideoPortsCollectionInitializer()
        {
            var collection = new VideoPortsCollection();
        }
    }
}
