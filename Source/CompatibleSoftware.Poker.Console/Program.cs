using System;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var table = CreateTable("Table 1", 2, 4);
            System.Console.WriteLine("Table Id is " + table.Id);
            
            var player1 = CreatePlayer("Player 1");
            System.Console.WriteLine("Player1 Id is " + player1.Id);
            
            var player2 = CreatePlayer("Player 2");
            System.Console.WriteLine("Player2 Id is " + player2.Id);
            
            var request1 = JoinTable(table, player1);
            System.Console.WriteLine("Player1 requests to join table " + request1.Id);
            
            var request2 = JoinTable(table, player2);
            System.Console.WriteLine("Player2 requests to join table " + request2.Id);
            
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

        private static JoinRequest JoinTable(Table table, Player player)
        {
            var joinRequest = new JoinRequest { TableId  = table.Id, PlayerId = player.Id};

            var task = ApiCaller<JoinRequest>.PostNew(String.Format("joinrequest"), joinRequest);

            return task.Result;
        }
    }
}
