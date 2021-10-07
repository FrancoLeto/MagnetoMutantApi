using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MutantDbContext : DbContext
    {
        public MutantDbContext(DbContextOptions<MutantDbContext> options) : base(options)
        {
        }

        public DbSet<DnaModel> Dnas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<DnaModel>().ToTable("Dnas");
        }
    }
}
