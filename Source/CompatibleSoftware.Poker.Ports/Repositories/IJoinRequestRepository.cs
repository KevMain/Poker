using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.Ports.Repositories
{
    public interface IJoinRequestRepository
    {
        JoinRequest Create(JoinRequest table);
    }
}
