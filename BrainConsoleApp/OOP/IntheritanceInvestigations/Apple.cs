using System;

namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{
    public class Apple : Fruit
    {
        public Apple(FruitColor color)
            : base(color)
        {
        }

        public override void Expire()
        {
            Color = FruitColor.Brown;

            base.Expire();
        }
    }
}