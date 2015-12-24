namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{
    public static class AppleColorConverters
    {
        public static FruitColor ToFruitColor(this AppleColor color)
        {
            return new FruitColor
            {
                ColorString = color.PrimaryColor + '/' + color.SecondaryColor
            };
        }
    }
}