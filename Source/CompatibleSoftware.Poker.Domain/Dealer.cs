namespace CompatibleSoftware.Poker.Domain
{
    public class Dealer : IDealer
    {
        private readonly IDeck _deck;

        public Dealer(IDeck deck)
        {
            _deck = deck;
        }

        public void Shuffle()
        {
            _deck.Shuffle();
        }

        public ICard DealTopCard()
        {
            _deck.BurnCard();

            return _deck.TakeTopCard();
        }
    }
}
