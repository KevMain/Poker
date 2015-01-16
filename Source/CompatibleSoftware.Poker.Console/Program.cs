using System.Collections.Generic;
using CompatibleSoftware.Poker.Domain;

namespace CompatibleSoftware.Poker.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(
                new Dealer(
                    new StandardDeck(
                        new StandardShuffleMethod()
                    )
                ), 
                GeneratePlayers(2));
            
            game.Play();

            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();
        }

        private static IList<IPlayer> GeneratePlayers(int numberOfPlayers)
        {
            var players = new List<IPlayer>();

            for (var i = 1; i <= numberOfPlayers; i++)
            {
                players.Add(new Player("Player" + i));
            }

            return players;
        }
    }
}
