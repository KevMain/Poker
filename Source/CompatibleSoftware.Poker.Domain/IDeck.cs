using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public interface IDeck
    {
        IList<ICard> GetCards();

        void SetCards(IList<ICard> cards);

        ICard TakeCardFromTop();

        void PutCardAtBottom(ICard card);
    }
}
