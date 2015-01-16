namespace CompatibleSoftware.Poker.Domain
{
    public interface IDealer
    {
        void Shuffle();

        ICard DealTopCard();
    }
}