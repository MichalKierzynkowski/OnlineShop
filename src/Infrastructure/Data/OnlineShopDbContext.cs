using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomerDetail> CustomerDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(GetSampleUsers());
            DataSeed.ModelBuilderExtensions.Seed(modelBuilder);
        }

        private IEnumerable<User> GetSampleUsers()
        {
            yield return new User("Mietek", "4C0ED5344CA916660508BEC6946534CE55EF71E874F613276015839C6E84CE3F".ToLower()); // dupa1234
            yield return new User("Staszek", "4C0ED5344CA916660508BEC6946534CE55EF71E874F613276015839C6E84CE3F".ToLower()); // dupa1234
            yield return new User("Ziutek", "4C0ED5344CA916660508BEC6946534CE55EF71E874F613276015839C6E84CE3F".ToLower()); // dupa1234
        }
    }
}
