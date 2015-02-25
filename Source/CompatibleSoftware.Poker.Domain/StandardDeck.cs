using System;
using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// Implementation of a standard deck of cards
    /// </summary>
    public class StandardDeck : DeckBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardDeck"/>
        /// </summary>
        public StandardDeck()
        {
            SetCards(CreateDeck());
        }

        /// <summary>
        /// Creates an internal list of cards of each Suit/Rank combination
        /// In a standard game this is a deck of 52 cards
        /// </summary>
        /// <returns>A list of generated cards</returns>
        private IList<ICard> CreateDeck()
        {
            var cards = new List<ICard>();

            cards.AddRange(from suit in (Suit[]) Enum.GetValues(typeof (Suit)) from rank in (Rank[]) Enum.GetValues(typeof (Rank)) select new Card(suit, rank));

            return cards;
        }
    }
}
