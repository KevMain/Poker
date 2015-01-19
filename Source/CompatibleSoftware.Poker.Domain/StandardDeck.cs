using System;
using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    public class StandardDeck : IDeck
    {
        private IList<ICard> _cards;

        public StandardDeck()
        {
            _cards = CreateDeck();
        }

        private IList<ICard> CreateDeck()
        {
            var cards = new List<ICard>();

            cards.AddRange(from suit in (Suit[]) Enum.GetValues(typeof (Suit)) from rank in (Rank[]) Enum.GetValues(typeof (Rank)) select new Card(suit, rank));

            return cards;
        }

        public IList<ICard> GetCards()
        {
            return _cards;
        }

        //TODO: Dislike this but need it to support sorting - need a better way to do it.
        public void SetCards(IList<ICard> cards)
        {
            _cards = cards;
        }

        public ICard TakeCardFromTop()
        {
            var card = _cards.FirstOrDefault();

            _cards.Remove(card);

            return card;
        }

        public void PutCardAtBottom(ICard card)
        {
            _cards.Add(card);
        }
    }
}
