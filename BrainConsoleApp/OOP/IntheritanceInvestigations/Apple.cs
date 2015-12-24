using System;

namespace BrainConsoleApp.OOP.IntheritanceInvestigations
{

    public static class AppleColorPalette
    {
        public static readonly AppleColor Good = new AppleColor()
        {
            PrimaryColor = "Green",
            SecondaryColor = "Yellow"
        };

        public static readonly AppleColor Expired = new AppleColor()
        {
            PrimaryColor = "Black",
            SecondaryColor = "Brown"
        };
    }

    public class Apple : Fruit
    {
        public Apple(AppleColor color)
            : base(color.ToFruitColor())
        {
        }

        private AppleColor _color;

        public new AppleColor Color
        {
            get { return _color; }
            set
            {
                _color = value;
                base.Color = _color.ToFruitColor();
            }
        }

        public override void Expire()
        {
            Color = AppleColorPalette.Expired;
            base.Expire();
        }
    }
}