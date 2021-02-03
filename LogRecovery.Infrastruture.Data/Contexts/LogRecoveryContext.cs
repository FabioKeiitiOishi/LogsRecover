using LogRecovery.Domain.Entities;
using LogRecovery.Infrastruture.Data.Extensions;
using LogRecovery.Infrastruture.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace LogRecovery.Infrastruture.Data.Contexts
{
    public class LogRecoveryContext : DbContext
    {
        public LogRecoveryContext(DbContextOptions<LogRecoveryContext> options)
            : base(options)
        {
        }

        public DbSet<Log> LogsRecoveries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LogMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
