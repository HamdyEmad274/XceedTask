using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XceedTask.Models;

namespace XceedTask.Data
{
    public class XceedDbContext : IdentityDbContext
    {
        public XceedDbContext() : base() { }

        public XceedDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phones" },
                new Category { Id = 2, Name = "Cars" },
                new Category { Id = 3, Name = "laptops" }
                );
        }

    }
}
