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
                player.ReceiveCard(_dealer.DealTopCard());
            }
        }
    }
}
