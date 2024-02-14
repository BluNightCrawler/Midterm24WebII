using Microsoft.EntityFrameworkCore;

using System.Data.Entity;

namespace Midterm24WebII.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Models.DBEntitys.Employee> Employee { get; set; }
    }
}
