namespace CompatibleSoftware.Poker.Domain.Models
{
    public abstract class BaseEntity : IPrimaryKeyEntity
    {
        public int Id { get; set; }
    }
}
