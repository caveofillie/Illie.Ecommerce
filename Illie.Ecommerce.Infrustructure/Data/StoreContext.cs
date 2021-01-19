using Illie.Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Illie.Ecommerce.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
