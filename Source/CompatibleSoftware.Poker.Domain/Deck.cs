using System;
using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    public class Deck
    {
        private IList<Card> _cards;
 
        public Deck()
        {
            _cards = CreateDeck();
        }

        private IList<Card> CreateDeck()
        {
            var cards = new List<Card>();

            foreach (var suit in (Suit[]) Enum.GetValues(typeof (Suit)))
            {
                cards.AddRange(from rank in (Rank[]) Enum.GetValues(typeof (Rank)) select new Card(suit, rank));
            }

            return cards;
        }

        public IList<Card> GetCards()
        {
            return _cards;
        }

        public void ShuffleCards()
        {
            _cards = _cards.OrderBy(c => Guid.NewGuid()).ToList();
        }

        public Card TakeCard()
        {
            var card = _cards.FirstOrDefault();
            
            _cards.Remove(card);

            return card;
        }
    }
}
