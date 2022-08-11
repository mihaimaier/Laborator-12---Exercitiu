using Laborator_12___Exercitiu.Card;
using Laborator_12___Exercitiu.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_12___Exercitiu.Players
{
    public class Player : IPlayer
    {
        public string Name { get; private set; }
        public Guid Id { get; set; }
        public int HandValue { get; set; }
        public List<Cards> Cards { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
            this.HandValue = 0;
            this.Cards = new List<Cards>();

        }
        public StringBuilder Description()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player Name: {this.Name}");
            sb.AppendLine($"Identifier: {this.Id}");
            sb.AppendLine($"Hand Value: {this.HandValue}");
            sb.AppendLine($"Cards: {this.Name}");

            foreach(Cards cards in this.Cards)
            {
                sb.AppendLine($"\t{cards}");
            }
            return sb;
        }
    }
}
