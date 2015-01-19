using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public class CommunityCards : ICommunityCards
    {
        private readonly IList<ICard> _cards;

        public CommunityCards()
        {
            _cards = new List<ICard>();
        }

        public void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public IList<ICard> GetCards()
        {
            return _cards;
        }
    }
}
