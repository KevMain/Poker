namespace CompatibleSoftware.Poker.Ports.Command
{
    public class CreatePlayerCommand : ICommand
    {
        public string Name { get; set; }
    }
}
