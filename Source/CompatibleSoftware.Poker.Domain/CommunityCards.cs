using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// A list of community cards that can be used to build a hand
    /// </summary>
    public class CommunityCards : ICommunityCards
    {
        /// <summary>
        /// An internal list of all currently dealt cards
        /// </summary>
        private readonly IList<ICard> _cards;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityCards"/> class
        /// </summary>
        public CommunityCards()
        {
            _cards = new List<ICard>();
        }

        /// <summary>
        /// Adds a card to the list of community cards
        /// </summary>
        /// <param name="card">The card to add</param>
        public void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        /// <summary>
        /// Gets the list of community cards
        /// </summary>
        /// <returns>A list of cards</returns>
        public IList<ICard> GetCards()
        {
            return _cards;
        }
    }
}
