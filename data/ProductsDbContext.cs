using Microsoft.EntityFrameworkCore;
using SuperMarket.model.entity;

namespace SuperMarketAPI.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("ServerConnection"));
        }

        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(p => p.id); // Configuring the primary key using Fluent API
        }
    }
}