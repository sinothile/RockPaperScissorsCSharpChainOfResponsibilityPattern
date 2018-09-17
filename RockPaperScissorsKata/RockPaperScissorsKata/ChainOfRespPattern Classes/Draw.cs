using RockPaperScissorsKata.Interfaces;

namespace RockPaperScissorsKata
{
    public class Draw : IGame
    {
        private IGame _parser;
        public void SetSuccessors(IGame parser)
        {
            _parser = parser;
        }
        public string Play(string playerOneChoice, string playerTwoChoice)
        {
            if ((playerOneChoice == "Rock" && playerTwoChoice == "Rock") || (playerOneChoice == "Paper" && playerTwoChoice == "Paper") || (playerOneChoice == "Scissors" && playerTwoChoice == "Scissors"))
            {
                return "Draw";
            }
            return "Player Two Won";
        }
    }
}
