namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{
    public struct AppleColor
    {
        public string PrimaryColor;
        public string SecondaryColor;

        public bool Equals(AppleColor other)
        {
            return string.Equals(PrimaryColor, other.PrimaryColor) && string.Equals(SecondaryColor, other.SecondaryColor);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is AppleColor && Equals((AppleColor) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((PrimaryColor != null ? PrimaryColor.GetHashCode() : 0)*397) ^ (SecondaryColor != null ? SecondaryColor.GetHashCode() : 0);
            }
        }

        public static bool operator ==(AppleColor left, AppleColor right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(AppleColor left, AppleColor right)
        {
            return !left.Equals(right);
        }
    }
}