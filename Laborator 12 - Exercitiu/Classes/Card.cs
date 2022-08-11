using System;

namespace Laborator_12___Exercitiu.Card
{
    public class Cards
    {
        public int Value { get; private set; }
        public Shapes Shape { get; private set; }

        public Cards(int value, Shapes shape)
        {
            this.Value = value;
            this.Shape = shape;
        }

        public override string ToString()
        {
            return $"{Value} of {Shape}";
        }
        public enum Shapes
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs,
        }
    }
}