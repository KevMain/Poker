namespace CompatibleSoftware.Poker.Domain.Tables
{
    public class TableRules
    {
        /// <summary>
        /// The minimum number of players required to start a game
        /// </summary>
        public int MinNumberOfPlayers { get; set; }
        
        /// <summary>
        /// The maximum amount of players aloud
        /// </summary>
        public int MaxNumberOfPlayers { get; set; }
    }
}
