namespace BrainConsoleApp.OOP.Operators
{
    public static class TemperatureConversions
    {
        public static Temperature ToCelsius(this Temperature temperature)
        {
            if (temperature.Units == Units.Celsius)
            {
                return temperature;
            }

            return new Temperature()
            {
                Units = Units.Celsius,
                Value = temperature.Value - 273
            };
        }
        
        public static Temperature ToKelvin(this Temperature temperature)
        {
            return temperature;
        }
    }
}