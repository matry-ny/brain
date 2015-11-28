using System;

namespace BrainConsoleApp.OOP.Methods
{
    public class StringFormatter
    {
        private const string Version = "0.1";
        public const string Square = "Square";
        public const string Rectagle = "Rectagle";
        public const string FigureFormat = "{0} ({1}x{2})";

        public string GetVersion()
        {
            return Version;
        }

        public string MakeInt(string format, int value)
        {
            return String.Format(format, value);
        }

        public string MakeFigure(int height, int width)
        {
            var figure = height == width ? Square : Rectagle;
            return String.Format(FigureFormat, figure, width, height);
        }

        public string MakeIntegersLine(string intFormat, char separator = ';', params int[] integers)
        {
            string result = "";
            foreach (var item in integers)
            {
                result += String.Format(intFormat, item) + separator;
            }
            return result.Trim(separator);
        }
    }
}