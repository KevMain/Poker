using CompatibleSoftware.Poker.Domain.Models;
using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Ports.Repositories
{
    public interface IPlayerRepository
    {
        IList<Player> GetAll();

        Player Create(Player player);
    }
}
