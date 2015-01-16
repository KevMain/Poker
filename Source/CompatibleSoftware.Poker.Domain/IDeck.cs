using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public interface IDeck
    {
        void Shuffle();

        IList<ICard> GetCards();

        ICard TakeTopCard();
    }
}
