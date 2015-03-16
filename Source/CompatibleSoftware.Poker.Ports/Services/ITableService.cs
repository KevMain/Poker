using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Ports.Services
{
    public interface ITableService
    {
        IList<IPokerTable> GetAllActiveTables();
    }
}