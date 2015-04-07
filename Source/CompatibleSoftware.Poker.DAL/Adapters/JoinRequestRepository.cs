using CompatibleSoftware.Poker.Domain.Models;
using CompatibleSoftware.Poker.Ports.Repositories;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    public class JoinRequestRepository : BaseRepository<JoinRequest>, IJoinRequestRepository
    {
        /// <summary>
        /// Creates a new join request
        /// </summary>
        /// <returns></returns>
        public JoinRequest Create(JoinRequest table)
        {
            return InternalRepository.Insert(table);
        }
    }
}
