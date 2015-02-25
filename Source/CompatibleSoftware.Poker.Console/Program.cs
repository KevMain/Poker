using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tableRules = new TableRules {MaxNumberOfSeats = 2};
            var table = new PokerTable(tableRules);
        }
    }
}
