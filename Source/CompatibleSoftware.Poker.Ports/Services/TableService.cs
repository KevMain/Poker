using System;
using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Command;
using CompatibleSoftware.Poker.Ports.Repositories;
using Player = CompatibleSoftware.Poker.Domain.Models.Player;

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
        /// An injected reference to the repo that deals with join requests
        /// </summary>
        private readonly IJoinRequestRepository _joinRequestRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableService"/> 
        /// with the specified repositories
        /// </summary>
        /// <param name="tableRepository">The table repository to use</param>
        /// <param name="joinRequestRepository">The join request repo to use</param>
        public TableService(ITableRepository tableRepository, IJoinRequestRepository joinRequestRepository)
        {
            _tableRepository = tableRepository;
            _joinRequestRepository = joinRequestRepository;
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

        /// <summary>
        /// Creates a request to join a table
        /// </summary>
        /// <param name="joinTableCommand">The join command object to handle</param>
        /// <returns>A new join request</returns>
        public JoinRequest JoinTable(JoinTableCommand joinTableCommand)
        {
            var joinRequest = new JoinRequest
            {
                PlayerId = joinTableCommand.PlayerId,
                TableId = joinTableCommand.TableId,
                RequestStatus = JoinStatus.InProgress
            };

            return _joinRequestRepository.Create(joinRequest);
        }

        public IList<Player> GetTablePlayers(int tableId)
        {
            throw new NotImplementedException();
        }
    }
}
