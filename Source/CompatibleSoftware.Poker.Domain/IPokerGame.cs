using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Domain
{
    public interface IPokerGame
    {
        IPokerTable PokerTable { get; }

        bool LeaveGame(Player p);

        int JoinGame(Player p);
    }
}
