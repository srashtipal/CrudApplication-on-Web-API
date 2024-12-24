using Microsoft.EntityFrameworkCore;

namespace CrudApplication_on_Web_API.Model
{
    public class BrandContext:DbContext
    {

        public BrandContext(DbContextOptions<BrandContext>options):base(options)
        {

        }

      public DbSet<Brand> Brands { get; set; }
    }
}
