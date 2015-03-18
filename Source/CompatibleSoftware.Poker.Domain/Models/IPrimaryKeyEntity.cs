namespace CompatibleSoftware.Poker.Domain.Models
{
    public interface IPrimaryKeyEntity : IEntity
    {
        int Id { get; set; }
    }
}
