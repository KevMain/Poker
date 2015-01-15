using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompatibleSoftware.Poker.Domain
{
    public class Card
    {
        private readonly Suit _suit;
        private readonly Rank _rank;

        public Card(Suit suit, Rank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public Rank GetRank()
        {
            return _rank;
        }

        public Suit GetSuit()
        {
            return _suit;
        }
    }
}
