using System.Collections.Generic;
using System.Text;

namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// Logic for the game of TexasHoldEm
    /// </summary>
    public class TexasHoldEm : GameBase, IGame
    {
        /// <summary>
        /// Defines the amount of cards each user will be dealt to begin the game
        /// </summary>
        private const int PocketCards = 2;

        /// <summary>
        /// Defines the amount of cards in the flop
        /// </summary>
        private const int FlopCards = 3;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="TexasHoldEm"/> class with
        /// the specified list of players
        /// </summary>
        /// <param name="players">A list of players to play the game</param>
        public TexasHoldEm(IList<IPlayer> players)
            : base(players, PocketCards)
        {
            Dealer = new Dealer(new StandardDeck(), new StandardShuffleMethod());
        }

        /// <summary>
        /// Starts a new game 
        /// </summary>
        public void PlayGame()
        {
            Dealer.Shuffle();

            DealPocketCards();

            DealFlop();

            DealTurn();

            DealRiver();
        }

        /// <summary>
        /// Deals the flop
        /// </summary>
        private void DealFlop()
        {
            for (var i = 0; i < FlopCards; i++) 
            {
                DealCommunityCard();
            }
        }

        /// <summary>
        /// Deal the turn card
        /// </summary>
        private void DealTurn()
        {
            DealCommunityCard();
        }

        /// <summary>
        /// Deal the river card
        /// </summary>
        private void DealRiver()
        {
            DealCommunityCard();
        }

        /// <summary>
        /// Outputs the current state of the game
        /// </summary>
        /// <returns>A string of current state</returns>
        public string ShowGameState()
        {
            var gameState = new StringBuilder();

            foreach (var player in Players)
            {
                gameState.AppendLine("----------------------------------");

                gameState.AppendLine("Player: " + player.GetName());

                foreach (var card in player.ShowCards())
                {
                    gameState.AppendLine(card.GetFriendlyName());
                }
            }

            gameState.AppendLine("----------------------------------");
            gameState.AppendLine("Community Cards");
                
            foreach (var card in CommunityCards.GetCards())
            {
                gameState.AppendLine(card.GetFriendlyName());
            }

            return gameState.ToString();
        }
    }
}
