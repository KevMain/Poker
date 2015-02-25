using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// The base class for all games which provides generic functions
    /// </summary>
    public abstract class GameBase
    {
        /// <summary>
        /// Defines the amount of cards each user will be dealt to begin the game
        /// </summary>
        internal readonly int TotalPocketCards;

        /// <summary>
        /// The list of players in the game
        /// </summary>
        internal readonly IList<IPlayer> Players;

        /// <summary>
        /// The dealer that will be used to play this game
        /// </summary>
        internal IDealer Dealer;

        /// <summary>
        /// A list of cards which can be used to make a hand
        /// </summary>
        internal ICommunityCards CommunityCards;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameBase"/> class with
        /// the list of players and the amount of pocket cards
        /// </summary>
        /// <param name="players"></param>
        /// <param name="pocketCards"></param>
        protected GameBase(IList<IPlayer> players, int pocketCards)
        {
            Players = players;
            TotalPocketCards = pocketCards;
            CommunityCards = new CommunityCards();
        }

        /// <summary>
        /// Deals the required amount of pocket cards to all players
        /// </summary>
        internal void DealPocketCards()
        {
            for (var i = 1; i <= TotalPocketCards; i++)
            {
                foreach (var player in Players)
                {
                    player.ReceiveCard(Dealer.DealTopCard());
                }
            }
        }

        /// <summary>
        /// Deals a community card
        /// </summary>
        internal void DealCommunityCard()
        {
            CommunityCards.AddCard(Dealer.DealTopCard());
        }
    }
}
