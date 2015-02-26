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
        /// The list of players at this table
        /// </summary>
        private readonly IList<IPlayer> _players;

        /// <summary>
        /// Initializes a new instance of the <see cref="PokerTable"/> 
        /// based on the passed in rules
        /// </summary>
        /// <param name="tableRules">The rules of the table</param>
        public PokerTable(TableRules tableRules)
        {
            _tableRules = tableRules;
            _players = new List<IPlayer>();
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
            
            _players.Add(player);

            return true;
        }

        /// <summary>
        /// Check to see if we have the maximum number of players at the table
        /// </summary>
        /// <returns>If the table is full or not</returns>
        private bool IsMaximumNumberOfPlayers()
        {
            return _players.Count >= _tableRules.MaxNumberOfPlayers;
        }

        /// <summary>
        /// Checks to see if the player is at the table
        /// </summary>
        /// <param name="playerToFind">The player we are looking for</param>
        /// <returns>If they are at the table or not</returns>
        private bool IsPlayerAtTable(IPlayer playerToFind)
        {
            return _players.Any(player => player.GetName() == playerToFind.GetName());
        }
    }
}
