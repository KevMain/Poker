using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Command;
using CompatibleSoftware.Poker.Ports.Repositories;

namespace CompatibleSoftware.Poker.Ports.Services
{
    /// <summary>
    /// Service which deals with poker tables
    /// </summary>
    public class TableService : ITableService
    {
        /// <summary>
        /// An injected reference to the repository we will use for storage of tables
        /// </summary>
        private readonly ITableRepository _tableRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableService"/> 
        /// with the specified repository
        /// </summary>
        /// <param name="tableRepository">The repository to use</param>
        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        /// <summary>
        /// Get a list of all currently active tables in the repository
        /// </summary>
        /// <returns>A list of Poker Tables</returns>
        public IList<Table> GetAllActiveTables()
        {
            return _tableRepository.GetAll();
        }

        /// <summary>
        /// Creates a new table
        /// </summary>
        /// <returns>The newly created table</returns>
        public Table CreateTable(CreateTableCommand createTableCommand)
        {
            var table = new Table
            {
                Name = createTableCommand.Name,
                MinNumberOfSeats = createTableCommand.MinNumberOfSeats,
                MaxNumberOfSeats = createTableCommand.MaxNumberOfSeats
            };

            return _tableRepository.Create(table);
        }
    }
}
