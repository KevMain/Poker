using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public interface ICommunityCards
    {
        void AddCard(ICard card);

        IList<ICard> GetCards();
    }
}