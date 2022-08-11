using System;
using System.Collections.Generic;
using System.Text;
using Laborator_12___Exercitiu.Card;
using static Laborator_12___Exercitiu.Card.Cards;

namespace Laborator_12___Exercitiu.Decks
{
    class Deck
    {
        public List<Cards> Cards { get; set; }

        public Deck()
        {
            this.Cards = CreateDeck();
        }
        private List<Cards> CreateDeck()
        {
            List<Cards> newDeck = new List<Cards>();

            for (int i = 0; i < Enum.GetNames(typeof(Shapes)).Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    newDeck.Add(new Cards(j + 1, (Shapes)i));
                }
            }
            return newDeck;
        }
    }
}
