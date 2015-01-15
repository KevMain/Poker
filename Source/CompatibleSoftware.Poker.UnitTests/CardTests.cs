using System;
using CompatibleSoftware.Poker.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompatibleSoftware.Poker.UnitTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void CardHasARankOf1()
        {
            const int expected = 1;

            var card = new Card(Suit.Clubs, Rank.Ace);

            var actual = card.GetRank();

            Assert.AreEqual(expected, (int)actual);
        }

        [TestMethod]
        public void DeckHas52Cards()
        {
            const int expected = 52;

            var deck = new Deck();

            Assert.AreEqual(expected, deck.GetCards().Count);
        }

        [TestMethod]
        public void DeckWhenNotShuffledFirstCardIsAceOfClubs()
        {
            var deck = new Deck();

            Assert.AreEqual(Rank.Ace, deck.GetCards()[0].GetRank());
            Assert.AreEqual(Suit.Clubs, deck.GetCards()[0].GetSuit());
        }

        [TestMethod]
        public void DeckWhenShuffledIsRandom()
        {
            const int expected = 1;

            var deck = new Deck();

            deck.ShuffleCards();

            Assert.AreNotEqual(expected, (int)deck.GetCards()[0].GetRank());
        }
    }
}
