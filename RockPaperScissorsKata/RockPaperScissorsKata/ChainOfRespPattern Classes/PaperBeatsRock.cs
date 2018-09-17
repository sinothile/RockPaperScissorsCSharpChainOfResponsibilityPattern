using System;
using RockPaperScissorsKata.Interfaces;

namespace RockPaperScissorsKata
{
    public class PaperBeatsRock : IGame
    {
        private IGame _parser;
        public void SetSuccessors(IGame parser)
        {
            _parser = parser;
        }

        public string Play(string playerOneChoice, string playerTwoChoice)
        {
            if (playerOneChoice == "Paper" && playerTwoChoice == "Rock")
            {
                return "Player One Won";
            }

            return _parser.Play(playerOneChoice, playerTwoChoice);
        }
    }
}
