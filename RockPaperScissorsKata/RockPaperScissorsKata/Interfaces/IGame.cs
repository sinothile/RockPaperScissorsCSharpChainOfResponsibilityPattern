namespace RockPaperScissorsKata.Interfaces
{
    public interface IGame
    {
        void SetSuccessors(IGame parser);
        string Play(string playerOneChoice, string playerTwoChoice);
    }
}
