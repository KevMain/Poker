using System;
using CompatibleSoftware.Poker.Ports.Command;

namespace CompatibleSoftware.Poker.Ports.Handlers
{
    public class JoinTableHandler : BaseHandler<JoinTableCommand>
    {
        public JoinTableHandler(JoinTableCommand command) : base(command)
        {
        }

        public override void Execute()
        {
            
        }
    }
}
