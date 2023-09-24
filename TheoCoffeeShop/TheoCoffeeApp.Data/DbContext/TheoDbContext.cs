using Microsoft.EntityFrameworkCore;
using TheoCoffeeApp.Data.Entities;

namespace TheoCoffeeApp.Data
{
    public class TheoDbContext : DbContext
    {
        public TheoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
