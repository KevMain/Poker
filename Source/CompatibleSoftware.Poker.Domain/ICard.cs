namespace CompatibleSoftware.Poker.Domain
{
    public interface ICard
    {
        Rank GetRank();

        Suit GetSuit();

        string GetFriendlyName();
    }
}