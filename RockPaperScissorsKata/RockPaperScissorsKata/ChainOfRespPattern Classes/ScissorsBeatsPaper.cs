using System;
using RockPaperScissorsKata.Interfaces;

namespace RockPaperScissorsKata
{
    public class ScissorsBeatsPaper : IGame
    {
        private IGame _parser;
        public void SetSuccessors(IGame parser)
        {
            _parser = parser;
        }

        public string Play(string playerOneChoice, string playerTwoChoice)
        {
            if (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")
            {
                return "Player One Won";
            }

            return _parser.Play(playerOneChoice, playerTwoChoice);
        }
    }
}
