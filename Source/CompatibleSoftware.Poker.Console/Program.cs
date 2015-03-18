using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var table = CreateTable();

            System.Console.WriteLine("Table Id is " + table.Id);

            //var player1 = CreatePlayer("Player 1");

            //var player2 = CreatePlayer("Player 2");
            
            
            //table.Join(player1);
            //table.Join(player2);

            //System.Console.WriteLine(table.PlayHand());

            //table.Leave(player1);
            //table.Leave(player2);

            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
        }

        private static Player CreatePlayer(string playerName)
        {
            var player = new Player { Id = 3, Name = playerName };

            var task = ApiCaller<Player>.PostNew("players", player);

            return task.Result;
        }

        private static Table CreateTable()
        {
            var table = new Table{Name = "Table 1", MinNumberOfSeats = 2, MaxNumberOfSeats = 6};

            var task = ApiCaller<Table>.PostNew("tables", table);

            return task.Result;
        }
    }
}
