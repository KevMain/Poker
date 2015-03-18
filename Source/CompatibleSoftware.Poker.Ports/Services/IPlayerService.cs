using CompatibleSoftware.Poker.Domain.Models;
using System.Collections.Generic;
using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Services
{
    public interface IPlayerService
    {
        IList<Player> GetAllCurrentPlayers();

        Player CreatePlayer(CreatePlayerCommand createPlayerCommand);
    }
}