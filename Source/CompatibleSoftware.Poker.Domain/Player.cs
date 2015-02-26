using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// The main Player class 
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary>
        /// The name of the player
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// The seat that this player is sat at
        /// </summary>
        private int _seatNumber;

        /// <summary>
        /// The cards in this players hand
        /// </summary>
        private readonly IList<ICard> _pocketCards;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class with the supplied name
        /// </summary>
        /// <param name="name">The player name</param>
        public Player(string name)
        {
            _name = name;
            _seatNumber = 0;
            _pocketCards = new List<ICard>();
        }

        /// <summary>
        /// Get the name of the current user
        /// </summary>
        /// <returns>The player name</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Adds a card to the players hand
        /// </summary>
        /// <param name="card">The card to add</param>
        public void ReceiveCard(ICard card)
        {
            _pocketCards.Add(card);
        }

        /// <summary>
        /// Show the cards that are in the players hand
        /// </summary>
        /// <returns>A list of cards that have been added</returns>
        public IList<ICard> ShowCards()
        {
            return _pocketCards;
        }

        /// <summary>
        /// Returns the players seat number
        /// </summary>
        /// <returns>The seat the player is sat at or 0 is not sat down</returns>
        public int GetSeatNumber()
        {
            return _seatNumber;
        }

        /// <summary>
        /// Set the seat the player is sat at
        /// </summary>
        /// <param name="seatNumber">The number of the seat they are sat at</param>
        public void SetSeatNumber(int seatNumber)
        {
            _seatNumber = seatNumber;
        }
    }
}