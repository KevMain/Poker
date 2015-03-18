using System.Data.Entity;
using CompatibleSoftware.Poker.DAL.Initializer;
using CompatibleSoftware.Poker.Domain.Models;

namespace CompatibleSoftware.Poker.DAL.Context
{
    public class PokerContext : DbContext
    {
        public DbSet<Table> Tables { get; set; }
        public DbSet<Player> Players { get; set; }

        public PokerContext()
            : base("PokerContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().HasKey(t => t.Id);
            modelBuilder.Entity<Player>().HasKey(t => t.Id);
        }
    }
}
