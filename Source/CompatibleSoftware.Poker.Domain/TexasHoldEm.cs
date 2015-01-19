using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public class TexasHoldEm : IGame
    {
        private readonly IDealer _dealer;
        private readonly IList<IPlayer> _players;
        private readonly ICommunityCards _communityCards;

        public TexasHoldEm(IList<IPlayer> players)
        {
            _dealer = new Dealer(new StandardDeck(), new StandardShuffleMethod());
            _players = players;
            _communityCards = new CommunityCards();
        }

        public void Play()
        {
            _dealer.Shuffle();

            for (var i = 1; i <= 2; i++)
            {
                foreach (var player in _players)
                {
                    player.ReceiveCard(_dealer.DealTopCard());
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                _communityCards.AddCard(_dealer.DealTopCard());
            }

            _communityCards.AddCard(_dealer.DealTopCard());

            _communityCards.AddCard(_dealer.DealTopCard());
        }

        public void ShowGameState()
        {
            foreach (var player in _players)
            {
                System.Console.WriteLine(player.GetName() + " has: ");
                foreach (var card in player.ShowCards())
                {
                    System.Console.WriteLine(card.GetFriendlyName());
                }
            }

            System.Console.WriteLine("Community Cards are: ");
            foreach (var card in _communityCards.GetCards())
            {
                System.Console.WriteLine(card.GetFriendlyName());
            }
        }

    }
}
