using Microsoft.EntityFrameworkCore;
using Practice.DataAccessLayer.Entities;

namespace Practice.BusinessLogicLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
