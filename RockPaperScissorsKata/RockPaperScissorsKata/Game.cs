namespace RockPaperScissorsKata
{
    public class Game
    {
        public string Play(string playerOneChoice, string playerTwoChoice)
        {
            if (playerOneChoice == "Rock" && playerTwoChoice == "Scissors")
            {
                return "Player One Won";
            }
            if (playerOneChoice == "Scissors" && playerTwoChoice == "Paper")
            {
                return "Player One Won";
            }
            if (playerOneChoice == "Paper" && playerTwoChoice == "Rock")
            {
                return "Player One Won";
            }

            if ((playerOneChoice == "Rock" && playerTwoChoice == "Rock") || (playerOneChoice == "Paper" && playerTwoChoice == "Paper") || (playerOneChoice == "Scissors" && playerTwoChoice == "Scissors"))
            {
                return "Draw";
            }
            return "Player Two Won";
        }
    }
}
