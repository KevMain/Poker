using CompatibleSoftware.Poker.Domain;
using CompatibleSoftware.Poker.Domain.Tables;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create the rules for the table
            var tableRules = new TableRules
            {
                MinNumberOfPlayers = 3,
                MaxNumberOfPlayers = 4
            };
            
            //Create the table based on the rules
            var table = new PokerTable(tableRules);

            //Create the players
            var player1 = new Player("Player 1");
            var player2 = new Player("Player 2");

            //Players join the table
            table.Join(player1);
            table.Join(player2);

            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
        }
    }
}
