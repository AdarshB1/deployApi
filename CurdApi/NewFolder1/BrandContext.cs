using Microsoft.EntityFrameworkCore;

namespace CurdApi.NewFolder1
{
    public class BrandContext : DbContext 
    {
        public BrandContext(DbContextOptions< BrandContext > options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
    }
}
