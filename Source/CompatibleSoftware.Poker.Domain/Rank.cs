namespace CompatibleSoftware.Poker.Domain
{
    /// <summary>
    /// An enum of card ranks
    /// Each Rank including picture cards is give a numeric rank for easier reference
    /// Ace is specified as Low but also could be High which the logic will take care of
    /// </summary>
    public enum Rank
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }
}