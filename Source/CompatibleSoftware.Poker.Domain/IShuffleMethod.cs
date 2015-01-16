using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public interface IShuffleMethod
    {
        IList<ICard> Shuffle(IList<ICard> cards);
    }
}
