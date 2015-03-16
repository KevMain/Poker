using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Ports.Repositories
{
    public interface ITableRepository
    {
        IList<IPokerTable> GetAll();
    }
}
