using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laborator_12___Exercitiu.Games;
using Laborator_12___Exercitiu.Interfaces;
using Laborator_12___Exercitiu.Players;

namespace Laborator_12___Exercitiu.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va modela finalul unui joc de carti blackjacjk.
            // un jucator de blackjack va fi caracterizat prin:

            //• un id de tip guid,
            //• un nume
            //• o lista de carti de joc.
            //• o functie care va returna descrierea acestuia(id, nume, lista cartilor) sub forma unui string.
            //  cărțile vor avea valori de la 1 la 14 și vor putea fi de mai multe tipuri

            // • inimă roșie
            // • inimă neagră
            // • romb
            // • trifoi

            // Clasa joc va avea o metoda evalueaza care va primi ca parametru o lista de jucatori si va returna guid - ul
            // jucatorilor castigator sau null in cazul in care nu exista niciun castigator.
            // evaluarea va fi urmatoarea:

            // • daca suma cartilor unui jucator depaseste 21 atunci el este pierzator
            // • jucatorul a carui valoare a sumei cartilor este cea mai apropiata de 21 va fi desemnat castigator.
            // • in cazul in care exista mai multi jucatori castigatori, va fi desemnat ca si castigator primul din
            // lista.

            // 1.creeati clasele, creeati cativa jucatori, evaluati - le cartile, afisati castigatorul in cazul in care
            // exista.
            // 2.testati unitar functia „evalueaza”
            // a.testati mai multe cazuri pentru functie
            // b.definiti o interfata pentru clasa „jucator”, si folositi mock - uri pentru a facilita testele
            // unitare.

            List<IPlayer> players = new List<IPlayer>
            {
            new Player("Mihai"),
            new Player("Alexandra"),
            new Player("Adrian"),
            new Player("Tudor"),
            new Player("Madalina"),
            new Player("Sonia"),
            };

            Game newGame = new Game();
            newGame.PlayGame(players);

            IPlayer winner = newGame.Evaluate(players);

            if (winner != null)
            {
                Console.WriteLine(winner.Description());
            }
            else
            {
                Console.WriteLine("Well this is sad :( .... Nobody Won!");
            }
        }
    }
}
