using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public class Game
    {
        private readonly IDealer _dealer;
        private readonly IList<IPlayer> _players;

        public Game(IDealer dealer, IList<IPlayer> players)
        {
            _dealer = dealer;
            _players = players;
        }

        public void Play()
        {
            _dealer.Shuffle();

            foreach (var player in _players)
            {
                var card = _dealer.DealTopCard();

                System.Console.WriteLine("Dealing to: " + player.GetName() + " the card " + card.GetFriendlyName());
                player.ReceiveCard(_dealer.DealTopCard());
            }
        }
    }
}
