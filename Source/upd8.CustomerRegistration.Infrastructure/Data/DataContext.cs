using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using upd8.CustomerRegistration.Domain.Entities;

namespace upd8.CustomerRegistration.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }

        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
