using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Services
{
    public interface ITableService
    {
        IList<Table> GetAllActiveTables();

        Table CreateTable(CreateTableCommand createTableCommand);
    }
}