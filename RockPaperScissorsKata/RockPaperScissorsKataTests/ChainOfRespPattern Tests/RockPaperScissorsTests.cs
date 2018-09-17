using NUnit.Framework;
using NUnit.Framework.Internal;
using RockPaperScissorsKata;

namespace RockPaperScissorsKataTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        [Test]
        public void Play_GivenPlayerOneChoosesRockAndPlayerTwoChoosesScissors_ShouldReturnPlayerOneWon()
        {
            //Arrange
            var playerOneChoice = "Rock";
            var playerTwoChoice = "Scissors";
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player One Won";
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Play_GivenPlayerOneChoosesScissorsAndPlayerTwoChoosesRock_ShouldReturnPlayerTwoWon()
        {
            //Arrange
            var playerOneChoice = "Scissors";
            var playerTwoChoice = "Rock";
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

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
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

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
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

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
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

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
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Player Two Won";
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Rock", "Rock")]
        [TestCase("Paper", "Paper")]
        [TestCase("Scissors", "Scissors")]
        public void Play_GivenPlayerOneChoosesRockAndPlayerTwoChooseRock_ShouldReturnDraw(string playerOneChoice, string playerTwoChoice)
        {
            //Arrange
            var rockBeatsScissors = new RockBeatsScissors();
            var scissorsBeatsPaper = new ScissorsBeatsPaper();
            var paperBeatsRock = new PaperBeatsRock();
            var draw = new Draw();

            rockBeatsScissors.SetSuccessors(scissorsBeatsPaper);
            scissorsBeatsPaper.SetSuccessors(paperBeatsRock);
            paperBeatsRock.SetSuccessors(draw);

            //Act
            var actual = rockBeatsScissors.Play(playerOneChoice, playerTwoChoice);

            //Assert
            var expected = "Draw";
            Assert.AreEqual(expected, actual);
        }
    }
}
