namespace CompatibleSoftware.Poker.Domain.Tables
{
    public interface IPokerTable
    {
        bool Join(IPlayer player);
    }
}
