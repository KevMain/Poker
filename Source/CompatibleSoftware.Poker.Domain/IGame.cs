namespace CompatibleSoftware.Poker.Domain
{
    public interface IGame
    {
        void PlayGame();

        string ShowGameState();
    }
}