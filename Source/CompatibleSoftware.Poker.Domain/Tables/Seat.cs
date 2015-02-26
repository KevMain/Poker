namespace CompatibleSoftware.Poker.Domain.Tables
{
    /// <summary>
    /// This class represents a seat at a Poker Table
    /// </summary>
    public class Seat : ISeat
    {
        /// <summary>
        /// The seat order number at the table
        /// once defined the seat number can't be changed
        /// </summary>
        private readonly int _seatNumber;

        /// <summary>
        /// The player assigned to this seat
        /// will be null if no player assigned yet
        /// </summary>
        private IPlayer _player;

        /// <summary>
        /// Initializes a new instance of the <see cref="Seat"/> class
        /// with the specified seat number
        /// </summary>
        /// <param name="seatNumber">The order number of the seat in regards to the table</param>
        public Seat(int seatNumber)
        {
            _seatNumber = seatNumber;
        }

        /// <summary>
        /// Fills the seat with the specified player
        /// </summary>
        /// <param name="player">The player to sit at the seat</param>
        public void SitDown(IPlayer player)
        {
            if (IsSeatEmpty())
            {
                _player = player;
            }
        }

        /// <summary>
        /// Vacates the seat by removing the player
        /// </summary>
        public void Vacate()
        {
            _player = null;
        }

        /// <summary>
        /// Checks to see if the current seat is empty
        /// </summary>
        /// <returns>If it is empty or not</returns>
        public bool IsSeatEmpty()
        {
            return _player == null;
        }

        /// <summary>
        /// Get the number of the seat
        /// </summary>
        /// <returns>The seat number</returns>
        public int GetSeatNumber()
        {
            return _seatNumber;
        }

        /// <summary>
        /// Gets the assigned player
        /// </summary>
        /// <returns>The Player or null if empty</returns>
        public IPlayer GetPlayer()
        {
            return _player;
        }
    }
}
