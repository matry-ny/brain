namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{
    public struct FruitColor

    {
        public static readonly FruitColor Green = new FruitColor() { ColorString = "Green" };
        public static readonly FruitColor Red = new FruitColor() { ColorString = "Red" };
        public static readonly FruitColor Brown = new FruitColor() { ColorString = "Brown" };
        public static readonly FruitColor Black = new FruitColor() { ColorString = "Black" };

        public string ColorString { get; set; }

        public bool Equals(FruitColor other)
        {
            return string.Equals(ColorString, other.ColorString);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is FruitColor && Equals((FruitColor) obj);
        }

        public override int GetHashCode()
        {
            return (ColorString != null ? ColorString.GetHashCode() : 0);
        }

        public static bool operator ==(FruitColor left, FruitColor right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(FruitColor left, FruitColor right)
        {
            return !left.Equals(right);
        }
    }
}