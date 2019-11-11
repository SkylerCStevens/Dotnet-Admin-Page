using Microsoft.EntityFrameworkCore;

namespace project4.Models
{
    public class ProductContext: DbContext //Context for how to save data in the database
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
       

    }
}
