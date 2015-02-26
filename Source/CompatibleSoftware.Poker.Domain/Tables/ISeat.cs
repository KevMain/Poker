namespace CompatibleSoftware.Poker.Domain.Tables
{
    public interface ISeat
    {
        int GetSeatNumber();

        IPlayer GetPlayer();

        bool IsSeatEmpty();

        void SitDown(IPlayer player);

        void Vacate();
    }
}
