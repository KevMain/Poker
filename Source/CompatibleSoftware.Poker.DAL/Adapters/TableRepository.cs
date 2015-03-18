using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Repositories;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    public class TableRepository : ITableRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly GenericRepository<Table> _internalRepository;

        /// <summary>
        /// 
        /// </summary>
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
