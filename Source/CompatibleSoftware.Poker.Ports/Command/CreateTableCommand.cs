namespace CompatibleSoftware.Poker.Ports.Command
{
    public class CreateTableCommand : ICommand
    {
        public string Name { get; set; }
        
        public int MaxNumberOfSeats { get; set; }

        public int MinNumberOfSeats { get; set; }
    }
}
