using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Game_shop.Models.DataModel;

namespace Game_shop.DataAccessLayer
{
    public class GameDbContext : DbContext
    {
        public GameDbContext() : base("name=GameDb")
        {

        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}