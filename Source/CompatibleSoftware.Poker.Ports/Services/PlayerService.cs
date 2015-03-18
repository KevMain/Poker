using System.Collections.Generic;
using CompatibleSoftware.Poker.Ports.Repositories;
using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Services
{
    /// <summary>
    /// Service which deals with players 
    /// </summary>
    public class PlayerService : IPlayerService
    {
        /// <summary>
        /// An injected reference to the repository we will use for storage of players
        /// </summary>
        private readonly IPlayerRepository _playerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerService"/> 
        /// with the specified repository
        /// </summary>
        /// <param name="playerRepository">The repository to use</param>
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        /// <summary>
        /// Get a list of all currently registered players in the repository
        /// </summary>
        /// <returns>A list of Players</returns>
        public IList<Player> GetAllCurrentPlayers()
        {
            return _playerRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="createPlayerCommand"></param>
        /// <returns></returns>
        public Player CreatePlayer(CreatePlayerCommand createPlayerCommand)
        {
            var player = new Player {Name = createPlayerCommand.Name};

            return _playerRepository.Create(player);
        }
    }
}
