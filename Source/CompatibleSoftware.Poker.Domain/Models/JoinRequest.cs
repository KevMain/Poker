namespace CompatibleSoftware.Poker.Domain.Models
{
    public class JoinRequest : BaseEntity
    {
        public int PlayerId;

        public int TableId;

        public JoinStatus RequestStatus;
    }

    public enum JoinStatus
    {
        InProgress,
        Succeded,
        Failed
    }
}
