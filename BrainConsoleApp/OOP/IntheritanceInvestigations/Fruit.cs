namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{
    public class Fruit
    {
        protected Fruit(FruitColor color)
        {
            Color = color;
        }

        public FruitColor Color { get; protected set; }

        public virtual void Expire()
        {
            IsExpired = true;
        }

        public bool IsExpired { get; private set; }
    }
}
