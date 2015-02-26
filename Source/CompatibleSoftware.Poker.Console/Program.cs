using CompatibleSoftware.Poker.Domain;
using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var table = new PokerTable(new TableRules {MinNumberOfPlayers = 2, MaxNumberOfPlayers = 4});

            var player1 = new Player("Player 1");
            table.Join(player1);

            var player2 = new Player("Player 2");
            table.Join(player2);

            System.Console.WriteLine(table.PlayHand());

            table.Leave(player1);
            table.Leave(player2);

            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
        }
    }
}
