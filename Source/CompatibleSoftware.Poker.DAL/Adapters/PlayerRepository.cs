using System.Collections.Generic;
using CompatibleSoftware.Poker.Ports.Repositories;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    public class PlayerRepository : IPlayerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly GenericRepository<Player> _internalRepository;

        /// <summary>
        /// 
        /// </summary>
        public PlayerRepository()
        {
            _internalRepository = new GenericRepository<Player>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Player> GetAll()
        {
            return _internalRepository.SelectAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public Player Create(Player player)
        {
            return _internalRepository.Insert(player);
        }
    }
}
