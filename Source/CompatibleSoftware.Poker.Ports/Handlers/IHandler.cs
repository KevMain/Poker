using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        void Execute();
    }
}
