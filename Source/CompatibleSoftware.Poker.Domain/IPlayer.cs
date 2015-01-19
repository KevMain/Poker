using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public interface IPlayer
    {
        string GetName();

        void ReceiveCard(ICard card);

        IList<ICard> ShowCards();
    }
}