using Microsoft.EntityFrameworkCore;
using OpenCity.Domain.Entities;

namespace OpenCity.Domain.Context {
    public class ApplicationContext : DbContext {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<OutboxMessage> OutboxMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Warning);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        }
    }
}
