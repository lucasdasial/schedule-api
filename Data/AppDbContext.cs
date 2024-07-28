using Microsoft.EntityFrameworkCore;
using schedule_api.Entities.Models;

namespace schedule_api.Data
{
    public class AppDbContext : DbContext
    {
        //TODO: procurar as maneiras seguras de passar a string de conexão com o banco
        // protected readonly IConfiguration Configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("User ID=agenda;Password=agenda;Host=localhost;Port=5432;Database=agenda;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Plan> Plans { get; set; } = default!;

    }
}
