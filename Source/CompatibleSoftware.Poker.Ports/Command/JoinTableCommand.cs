namespace CompatibleSoftware.Poker.Ports.Command
{
    public class JoinTableCommand
    {
        public int TableId { get; set; }
        
        public int PlayerId { get; set; }
    }
}
