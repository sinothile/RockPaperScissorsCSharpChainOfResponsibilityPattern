﻿using System;
using RockPaperScissorsKata.Interfaces;

namespace RockPaperScissorsKata
{
    public class RockBeatsScissors : IGame
    {
        private IGame _parser;
        public void SetSuccessors(IGame parser)
        {
            _parser = parser;
        }

        public string Play(string playerOneChoice, string playerTwoChoice)
        {
            if (playerOneChoice == "Rock" && playerTwoChoice == "Scissors")
            {
                return "Player One Won";
            }

            return _parser.Play(playerOneChoice, playerTwoChoice);
        }
    }
}
