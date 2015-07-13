namespace CompatibleSoftware.Poker.Ports.Command
{
    public class JoinTableCommand : ICommand
    {
        public int TableId { get; set; }
        
        public int PlayerId { get; set; }
    }
}
