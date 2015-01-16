using System.Collections.Generic;

namespace CompatibleSoftware.Poker.Domain
{
    public class Player : IPlayer
    {
        private readonly string _name;

        private readonly IList<ICard> _pocketCards;

        public Player(string name)
        {
            _name = name;
            _pocketCards = new List<ICard>();
        }

        public string GetName()
        {
            return _name;
        }

        public void ReceiveCard(ICard card)
        {
            _pocketCards.Add(card);
        }
    }
}