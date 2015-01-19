namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// This is the main Dealer class
    /// The Dealer is responsible for any interaction with the card deck
    /// </summary>
    public class Dealer : IDealer
    {
        /// <summary>
        /// The deck of cards the dealer has has been passed to use for this game
        /// </summary>
        private readonly IDeck _deck;

        /// <summary>
        /// The method the dealer will use for shuffling the cards
        /// </summary>
        private readonly IShuffleMethod _shuffleMethod;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dealer"/> class with
        /// the supplied <see cref="IDeck"/> and <see cref="IShuffleMethod"/>
        /// </summary>
        /// <param name="deck">The deck of cards to use</param>
        /// <param name="shuffleMethod">A method that will be used for sorting</param>
        public Dealer(IDeck deck, IShuffleMethod shuffleMethod)
        {
            _deck = deck;
            _shuffleMethod = shuffleMethod;
        }

        /// <summary>
        /// Shuffles the deck of card using the specfic <see cref="IShuffleMethod"/>
        /// </summary>
        public void Shuffle()
        {
            _shuffleMethod.Shuffle(_deck);
        }

        /// <summary>
        /// Deals the next card
        /// </summary>
        /// <returns>The card from the top of the deck</returns>
        public ICard DealTopCard()
        {       
            // In Casino Poker the card on top is always "burned" before a card is dealt
            BurnCard();

            return _deck.TakeCardFromTop();
        }

        /// <summary>
        /// Take the card at the top of the deck and move it to the bottom
        /// </summary>
        private void BurnCard()
        {
            _deck.PutCardAtBottom(_deck.TakeCardFromTop());
        }
    }
}
