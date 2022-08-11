using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laborator_12___Exercitiu.Games;
using System;
using System.Collections.Generic;
using System.Text;
using Laborator_12___Exercitiu.Interfaces;
using Laborator_12___Exercitiu.Players;
using Laborator_12___Exercitiu.Card;
using static Laborator_12___Exercitiu.Card.Cards;
using Moq;

namespace Laborator_12___Exercitiu.Games.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void EvaluateTest1()
        {
            //Arrange

            IPlayer player1 = new Player("Mihai");
            player1.Cards.Add(new Cards(8, Shapes.Clubs));
            player1.Cards.Add(new Cards(5, Shapes.Diamonds));
            player1.Cards.Add(new Cards(4, Shapes.Clubs));
            player1.HandValue = 17;

            IPlayer player2 = new Player("Alexandra");
            player2.Cards.Add(new Cards(9, Shapes.Hearts));
            player2.Cards.Add(new Cards(2, Shapes.Spades));
            player2.Cards.Add(new Cards(10, Shapes.Hearts));
            player2.HandValue = 21;

            IPlayer player3 = new Player("Adrian");
            player3.Cards.Add(new Cards(5, Shapes.Diamonds));
            player3.Cards.Add(new Cards(3, Shapes.Spades));
            player3.Cards.Add(new Cards(5, Shapes.Spades));
            player3.HandValue = 13;

            List<IPlayer> players = new List<IPlayer>
            { player1,
              player2,
              player3,
            };

            //Act

            Game newGame = new Game();
            Guid expectedResult = player3.Id;
            Guid actualResult = newGame.Evaluate(players).Id;

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void EvaluateTest2()
        {
            //Arrange

            IPlayer player1 = new Player("Tudor");
            player1.Cards.Add(new Cards(5, Shapes.Diamonds));
            player1.Cards.Add(new Cards(5, Shapes.Diamonds));
            player1.Cards.Add(new Cards(9, Shapes.Diamonds));
            player1.HandValue = 19;

            IPlayer player2 = new Player("Madalina");
            player2.Cards.Add(new Cards(9, Shapes.Spades));
            player2.Cards.Add(new Cards(2, Shapes.Spades));
            player2.Cards.Add(new Cards(10, Shapes.Clubs));
            player2.HandValue = 21;

            IPlayer player3 = new Player("Sonia");
            player3.Cards.Add(new Cards(10, Shapes.Hearts));
            player3.Cards.Add(new Cards(7, Shapes.Spades));
            player3.Cards.Add(new Cards(8, Shapes.Diamonds));
            player3.HandValue = 25;

            List<IPlayer> players = new List<IPlayer>
            { player1,
              player2,
              player3,
            };

            //Act

            Game newGame = new Game();
            int expectedResult = 21;
            int actualResult = newGame.Evaluate(players).HandValue;

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void IPlayerTest1()
        {
            IPlayer player = GetMock1("Mihai");
            string expectedResult = "Mihai";

            Assert.AreEqual(expectedResult, player.Name);
        }
        private IPlayer GetMock1(string name)
        {
            Mock<IPlayer> playerMock = new Mock<IPlayer>();
            playerMock.Setup(p => p.Name).Returns(name);
            return playerMock.Object;
        }
        [TestMethod()]
        public void IPlayerTest2()
        {
            IPlayer player = GetMock2(12);
            int expectedResult = 15;

            Assert.AreEqual(expectedResult, player.HandValue);
        }
        private IPlayer GetMock2(int value)
        {
            Mock<IPlayer> playerMock = new Mock<IPlayer>();
            playerMock.Setup(p => p.HandValue).Returns(value);
            return playerMock.Object;
        }
    }
}