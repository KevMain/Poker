using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// Abstract card for dealing with generic deck functions
    /// </summary>
    public abstract class DeckBase : IDeck
    {
        /// <summary>
        /// Internal list of cards in the deck
        /// </summary>
        private IList<ICard> _cards;

        /// <summary>
        /// Gets the full deck of cards
        /// </summary>
        /// <returns>The deck of cards</returns>
        public IList<ICard> GetCards()
        {
            return _cards;
        }

        /// <summary>
        /// Sets the full deck of cards
        /// </summary>
        /// <param name="cards">A list of cards to set as a deck</param>
        public void SetCards(IList<ICard> cards)
        {
            _cards = cards;
        }

        /// <summary>
        /// Takes the first card from the top of the deck
        /// </summary>
        /// <returns>The first card in the deck</returns>
        public ICard TakeCardFromTop()
        {
            var card = _cards.FirstOrDefault();

            _cards.Remove(card);

            return card;
        }

        /// <summary>
        /// Adds a card to the bottom of the deck
        /// </summary>
        /// <param name="card">The card to add</param>
        public void PutCardAtBottom(ICard card)
        {
            _cards.Add(card);
        }
    }
}
