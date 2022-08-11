using Laborator_12___Exercitiu.Card;
using Laborator_12___Exercitiu.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator_12___Exercitiu.Dealers
{
    class Dealer
    {
        public Deck Deck { get; private set; }

        public Dealer()
        {
            Deck = new Deck();
            Deck.Cards = ShuffleDeck();
        }
        private List<Cards> ShuffleDeck()
        {
            List<Cards> shuffleDeck = new List<Cards>();

            shuffleDeck.AddRange(Deck.Cards);

            Random random = new Random();

            for (int i = 0; i < shuffleDeck.Count; i++)
            {
                int randomShuffleCards = random.Next(i, shuffleDeck.Count);
                (shuffleDeck[randomShuffleCards], shuffleDeck[i]) = (shuffleDeck[i], shuffleDeck[randomShuffleCards]);
            }
            return shuffleDeck;
        }
    }
}