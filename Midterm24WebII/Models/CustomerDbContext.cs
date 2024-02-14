using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Midterm24WebII.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options): base(options) { }
        public DbSet<Customer> Info => Set<Customer>();
    }
}
