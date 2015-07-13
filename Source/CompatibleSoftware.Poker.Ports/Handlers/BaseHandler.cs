using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Handlers
{
    public abstract class BaseHandler<T> : IHandler<ICommand>
    {
        public readonly T Command;

        protected BaseHandler(T command)
        {
            Command = command;
        }

        public abstract void Execute();
    }
}
