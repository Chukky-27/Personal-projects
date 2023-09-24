using MateData.Models;
using Microsoft.EntityFrameworkCore;


namespace MateData.UserDbContext
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Customer> Customers2 { get; set; }
        public DbSet<Order> Orders2 { get; set; }


    }


}
