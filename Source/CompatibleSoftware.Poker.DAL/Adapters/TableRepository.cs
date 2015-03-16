using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Tables;
using CompatibleSoftware.Poker.Ports.Repositories;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    /// <summary>
    /// In memory repository to be used until storage strategy defined
    /// </summary>
    public class TableRepository : ITableRepository
    {
        /// <summary>
        /// Get a list of all Poker Tables in the repository
        /// </summary>
        /// <returns></returns>
        public IList<IPokerTable> GetAll()
        {
            return new List<IPokerTable> {new PokerTable(new TableRules()), new PokerTable(new TableRules())};
        }
    }
}
