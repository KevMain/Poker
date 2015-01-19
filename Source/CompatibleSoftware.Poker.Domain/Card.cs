namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// This is the main class for representing a playing card
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// The suit of the current card
        /// </summary>
        private readonly Suit _suit;
 
        /// <summary>
        /// The rank of the current card
        /// </summary>
        private readonly Rank _rank;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class with 
        /// the defined Suit and Rank
        /// </summary>
        /// <param name="suit">The suit of the card</param>
        /// <param name="rank">The rank of the card</param>
        public Card(Suit suit, Rank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        /// <summary>
        /// Get the rank of the current card
        /// </summary>
        /// <returns>The rank of the card</returns>
        public Rank GetRank()
        {
            return _rank;
        }

        /// <summary>
        /// Get the suit of the current card
        /// </summary>
        /// <returns>The suit of the card</returns>
        public Suit GetSuit()
        {
            return _suit;
        }

        /// <summary>
        /// Return a friendly name combining the Suit and the Rank
        /// </summary>
        /// <returns>A friendly name for the card</returns>
        public string GetFriendlyName()
        {
            return _rank + " of " + _suit;
        }
    }
}
