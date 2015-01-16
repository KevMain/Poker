namespace CompatibleSoftware.Poker.Domain
{
    public interface IPlayer
    {
        string GetName();

        void ReceiveCard(ICard card);
    }
}