using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.Ports.Repositories
{
    public interface ITableRepository
    {
        IList<Table> GetAll();

        Table Create(Table table);
    }
}
