using System.Collections.Generic;
using System.Linq;

namespace CompatibleSoftware.Poker.Domain.Tables
{
    /// <summary>
    /// This is the main class which represents a Poker Table
    /// </summary>
    public class PokerTable : IPokerTable
    {
        /// <summary>
        /// A list of rules which define this table
        /// </summary>
        private readonly TableRules _tableRules;

        /// <summary>
        /// The seats at the table
        /// </summary>
        private readonly IList<ISeat> _seats;

        /// <summary>
        /// Initializes a new instance of the <see cref="PokerTable"/> 
        /// based on the passed in rules
        /// </summary>
        /// <param name="tableRules">The rules of the table</param>
        public PokerTable(TableRules tableRules)
        {
            _tableRules = tableRules;
            
            _seats = new List<ISeat>();

            for (var i = 1; i <= _tableRules.MaxNumberOfPlayers; i++)
                _seats.Add(new Seat(i));
        }

        /// <summary>
        /// Allows a Player to join a table
        /// </summary>
        /// <param name="player">The player who wants to join</param>
        /// <returns>A bool of if the player has been allowed to join or not</returns>
        public bool Join(IPlayer player)
        {
            if (IsMaximumNumberOfPlayers())
                return false;

            if (IsPlayerAtTable(player))
                return false;

            AssignPlayerToSeat(player, GetFirstEmptySeat());

            return true;
        }

        public string PlayHand()
        {
            //TODO: Refactor this

            var game = new TexasHoldEm(GetCurrentPlayers());

            game.PlayGame();

            return game.ShowGameState();
        }

        /// <summary>
        /// Finds the first seat at the table not taken by any player
        /// </summary>
        /// <returns>The first available seat</returns>
        private ISeat GetFirstEmptySeat()
        {
            return _seats.OrderBy(s => s.GetSeatNumber()).FirstOrDefault(seat => seat.IsSeatEmpty());
        }

        /// <summary>
        /// Assigns the specified player to the seat
        /// </summary>
        /// <param name="player">The player to assign</param>
        /// <param name="seat">The seat to assign them to</param>
        private void AssignPlayerToSeat(IPlayer player, ISeat seat)
        {
            seat.SitDown(player);
            player.SetSeatNumber(seat.GetSeatNumber());
        }

        /// <summary>
        /// Removes the player from the table
        /// </summary>
        /// <param name="player">The player to remove</param>
        public void Leave(IPlayer player)
        {
            if (IsPlayerAtTable(player))
            {
                _seats[player.GetSeatNumber()].Vacate();
                player.SetSeatNumber(0);
            }
        }

        /// <summary>
        /// Gets a list of all current players
        /// </summary>
        /// <returns>A list of all current players</returns>
        private List<IPlayer> GetCurrentPlayers()
        {
            return _seats.Where(s => !s.IsSeatEmpty()).Select(s => s.GetPlayer()).ToList();
        }

        /// <summary>
        /// Check to see if we have the maximum number of players at the table
        /// </summary>
        /// <returns>If the table is full or not</returns>
        private bool IsMaximumNumberOfPlayers()
        {
            return GetCurrentPlayers().Count >= _tableRules.MaxNumberOfPlayers;
        }

        /// <summary>
        /// Checks to see if the player is at the table
        /// </summary>
        /// <param name="playerToFind">The player we are looking for</param>
        /// <returns>If they are at the table or not</returns>
        private bool IsPlayerAtTable(IPlayer playerToFind)
        {
            return GetCurrentPlayers().Any(player => player.GetName() == playerToFind.GetName());
        }
    }
}
