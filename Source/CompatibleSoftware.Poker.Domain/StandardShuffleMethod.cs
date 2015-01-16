using System;
using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain
{
    public class StandardShuffleMethod : IShuffleMethod
    {
        public IList<ICard> Shuffle(IList<ICard> cards)
        {
            return cards.OrderBy(c => Guid.NewGuid()).ToList();
        }
    }
}
