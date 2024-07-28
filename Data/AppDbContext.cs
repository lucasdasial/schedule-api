using Microsoft.EntityFrameworkCore;
using schedule_api.models;

namespace schedule_api.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql();
        }
    }
}
