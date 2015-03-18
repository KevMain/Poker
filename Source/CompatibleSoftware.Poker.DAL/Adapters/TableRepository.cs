using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Repositories;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    /// <summary>
    /// In memory repository to be used until storage strategy defined
    /// </summary>
    public class TableRepository : ITableRepository
    {
        private readonly GenericRepository<Table> _internalRepository;

        public TableRepository()
        {
            _internalRepository = new GenericRepository<Table>();
        }

        /// <summary>
        /// Get a list of all Poker Tables in the repository
        /// </summary>
        /// <returns></returns>
        public IList<Table> GetAll()
        {
            return _internalRepository.SelectAll();
        }

        /// <summary>
        /// Get a list of all Poker Tables in the repository
        /// </summary>
        /// <returns></returns>
        public Table Create(Table table)
        {
            return _internalRepository.Insert(table);
        }
    }
}
