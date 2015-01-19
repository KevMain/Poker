using System;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// This is the default shuffle method
    /// Provides a random distribution of cards
    /// </summary>
    public class StandardShuffleMethod : IShuffleMethod
    {
        /// <summary>
        /// Performs the actual shuffle
        /// </summary>
        /// <param name="deck">The deck to shuffle</param>
        public void Shuffle(IDeck deck)
        {
            //Method: Generate and sort by a unique Guid for each card
            //See http://blog.codinghorror.com/shuffling/ 
            deck.SetCards(deck.GetCards().OrderBy(c => Guid.NewGuid()).ToList());
        }
    }
}
