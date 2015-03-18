using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var table = CreateTable("Table 1", 2, 4);

            var player1 = CreatePlayer("Player 1");

            var player2 = CreatePlayer("Player 2");

            System.Console.WriteLine("Table Id is " + table.Id);
            System.Console.WriteLine("Player1 Id is " + player1.Id);
            System.Console.WriteLine("Player2 Id is " + player2.Id);
            
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
            var player = new Player {Name = playerName};

            var task = ApiCaller<Player>.PostNew("players", player);

            return task.Result;
        }

        private static Table CreateTable(string tableName, int minNumSeats, int maxNumSeats)
        {
            var table = new Table { Name = tableName, MinNumberOfSeats = minNumSeats, MaxNumberOfSeats = maxNumSeats };

            var task = ApiCaller<Table>.PostNew("tables", table);

            return task.Result;
        }
    }
}
