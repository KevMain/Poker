using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain.Tables
{
    public class PokerTable : IPokerTable
    {
        private readonly IList<ISeat> _seats;

        public PokerTable(TableRules tableRules)
        {
            _seats = new List<ISeat>(tableRules.MaxNumberOfSeats);
        }
    }
}
