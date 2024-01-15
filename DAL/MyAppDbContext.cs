using Microsoft.EntityFrameworkCore;
using Self_Practice.Models.DBEntities;

namespace Self_Practice.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
