using Microsoft.EntityFrameworkCore;

namespace WebApp1.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
