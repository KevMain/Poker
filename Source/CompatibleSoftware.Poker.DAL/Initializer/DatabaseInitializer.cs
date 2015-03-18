using System.Data.Entity;
using CompatibleSoftware.Poker.DAL.Context;

namespace CompatibleSoftware.Poker.DAL.Initializer
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<PokerContext>
    {
    }
}
