using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrainConsoleAppTest
{
    public struct ColorRGB
    {
        public byte R;
        public byte G;
        public byte B;

        public override string ToString()
        {
            return String.Format("R: {0} G: {1} B: {2}", R, G, B);
        }
    }

    [TestClass]
    public class StructuresTest
    {
        [TestMethod]
        public void toStringTest()
        {
            var color = new ColorRGB
            {
                R = 1,
                G = 2
            };
            color.B = 3;

            Debug.WriteLine(color.ToString());
        }
    }
}
