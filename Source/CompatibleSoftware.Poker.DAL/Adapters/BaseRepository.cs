using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Adapters
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// A reference to the internal repo which handles most of the work
        /// </summary>
        protected readonly GenericRepository<T> InternalRepository;

        protected BaseRepository()
        {
            InternalRepository = new GenericRepository<T>();
        }
    }
}
