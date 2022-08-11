using Laborator_12___Exercitiu.Decks;
using Laborator_12___Exercitiu.Dealers;
using Laborator_12___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_12___Exercitiu.Games
{
    public class Game
    {
        public IPlayer Evaluate(List<IPlayer> players)
        {
            IPlayer winner = null;

            if (players.Count < 2) return winner;

            foreach(IPlayer player in players)
            {
                if (player.HandValue < 22)
                {
                    winner = player;
                    break;
                }
            }
            if (winner == null) return winner;

            foreach(IPlayer player in players)
            {
                if(player.HandValue < 22 && player.HandValue > winner.HandValue)
                {
                    winner = player;
                }
            }
            return winner;
        }
        public void PlayGame(List<IPlayer> players)
        {
            Deck deck = new Dealer().Deck;

            foreach(IPlayer player in players)
            {
                while (player.HandValue <= 17)
                {
                    player.Cards.Add(deck.Cards[0]);

                    if(deck.Cards[0].Value ==11 || deck.Cards[0].Value == 12 || deck.Cards[0].Value == 13)
                    {
                        player.HandValue += 10;
                    }
                    else if (deck.Cards[0].Value ==1 && player.HandValue < 11)
                    {
                        player.HandValue += 11;
                    }
                    else if(deck.Cards[0].Value == 1 && player.HandValue > 10)
                    {
                        player.HandValue += 1;
                    }
                    else
                    {
                        player.HandValue += deck.Cards[0].Value;
                    }

                    deck.Cards.RemoveAt(0);
                }
            }
        }
    }
}
