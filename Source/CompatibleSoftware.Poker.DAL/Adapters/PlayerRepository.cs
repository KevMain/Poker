using System.Collections.Generic;
using CompatibleSoftware.Poker.Ports.Repositories;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    /// <summary>
    /// In memory repository to be used until storage strategy defined
    /// </summary>
    public class PlayerRepository : IPlayerRepository
    {
        private readonly IList<Player> _players =  new List<Player>
        {
            new Player {Id = 1, Name = "Wayne Rooney"},
            new Player {Id = 1, Name = "Bob Smith"}
        };
 
        public IList<Player> GetAll()
        {
            return _players;
        }

        public Player Create(Player player)
        {
            _players.Add(player);

            return player;
        }
    }
}
