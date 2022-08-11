using Laborator_12___Exercitiu.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_12___Exercitiu.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        int HandValue { get; set; }
        Guid Id { get; }
        List<Cards> Cards { get; }

        StringBuilder Description();
    }
}
