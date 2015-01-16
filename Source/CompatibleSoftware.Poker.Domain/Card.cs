namespace CompatibleSoftware.Poker.Domain
{
    public class Card : ICard
    {
        private readonly Suit _suit;
        private readonly Rank _rank;

        public Card(Suit suit, Rank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public Rank GetRank()
        {
            return _rank;
        }

        public Suit GetSuit()
        {
            return _suit;
        }

        public string GetFriendlyName()
        {
            return _rank + " of " + _suit;
        }
    }
}
