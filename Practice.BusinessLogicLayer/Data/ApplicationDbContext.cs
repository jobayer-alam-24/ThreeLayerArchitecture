using Microsoft.EntityFrameworkCore;
using Practice.DataAccessLayer.Entities;

namespace Practice.BusinessLogicLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MJB7RA8;Database=PracticeThreeLayer;Encrypt=false;Trusted_Connection=true;MultipleActiveResultSets=false");
        }
    }
}
