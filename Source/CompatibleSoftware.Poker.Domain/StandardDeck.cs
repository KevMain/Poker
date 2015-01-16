using System;
using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    public class StandardDeck : IDeck
    {
        private readonly IShuffleMethod _shuffleMethod;

        private IList<ICard> _cards;

        public StandardDeck(IShuffleMethod shuffleMethod)
        {
            _shuffleMethod = shuffleMethod;
            _cards = CreateDeck();
        }

        private IList<ICard> CreateDeck()
        {
            var cards = new List<ICard>();

            cards.AddRange(from suit in (Suit[]) Enum.GetValues(typeof (Suit)) from rank in (Rank[]) Enum.GetValues(typeof (Rank)) select new Card(suit, rank));

            return cards;
        }

        public void Shuffle()
        {
            _cards = _shuffleMethod.Shuffle(_cards);
        }

        public IList<ICard> GetCards()
        {
            return _cards;
        }

        public ICard TakeTopCard()
        {
            var card = _cards.FirstOrDefault();

            _cards.Remove(card);

            return card;
        }
    }
}
