using Microsoft.EntityFrameworkCore;
using Zhuravlev_34.Models;

namespace Zhuravlev_34
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;Database=test_db_first;User Id=postgres;Password=123456";

        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Sell> SellOrders { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
    }
}
