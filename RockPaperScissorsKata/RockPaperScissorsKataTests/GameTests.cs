using System.Runtime.InteropServices;
using NUnit.Framework;
using RockPaperScissorsKata;

namespace RockPaperScissorsKataTests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Play_GivenPlayerOneChoosesRockAndPlayerTwoChoosesScissors_ShouldReturnPlayerOneWon()
        {
            //Arrange
            var playerOneChoice = "Rock";
            var playerTwoChoice = "Scissors";
            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player One Won";
            Assert.AreEqual(expected, actual);
        }

        [Test]  
        public void Play_GivenPlayerOneChoosesScissorsAndPlayerTwoChoosesRock_ShouldReturnPlayerTwoWon()
        {
            //Arrange
            var playerOneChoice = "Scissors";
            var playerTwoChoice = "Rock";

            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player Two Won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerOneChoosesScissorsAndPlayerTwoChoosesPaper_ShouldReturnPlayerOneWon()
        {
            //Arrange
            var playerOneChoice = "Scissors";
            var playerTwoChoice = "Paper";

            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player One Won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerOneChoosesPaperAndPlayerTwoChoosesScissors_ShouldReturnPlayerTwoWon()
        {
            //Arrange
            var playerOneChoice = "Paper";
            var playerTwoChoice = "Scissors";

            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player Two Won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerOneChoosesPaperAndPlayerTwoChoosesRock_ShouldReturnPlayerOneWon()
        {
            //Arrange
            var playerOneChoice = "Paper";
            var playerTwoChoice = "Rock";

            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player One Won";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Play_GivenPlayerOneChoosesRockAndPlayerTwoChoosePaper_ShouldReturnPlayerTwoWon()
        {
            //Arrange
            var playerOneChoice = "Rock";
            var playerTwoChoice = "Paper";

            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player Two Won";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Rock","Rock")]
        [TestCase("Paper","Paper")]
        [TestCase("Scissors","Scissors")]
        public void Play_GivenPlayerOneChoosesRockAndPlayerTwoChooseRock_ShouldReturnDraw(string playerOneChoice, string playerTwoChoice)
        {
            //Arrange
            var sut = CreateGame();

            //Act
            var actual = sut.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }

        private Game CreateGame()
        {
            return new Game();
        }
    }
}
