namespace CompatibleSoftware.Poker.Domain.Models
{
    public class Table : BaseEntity
    {
        public string Name { get; set; }

        public int MaxNumberOfSeats { get; set; }

        public int MinNumberOfSeats { get; set; }

    }
}
