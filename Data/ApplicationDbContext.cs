using Microsoft.EntityFrameworkCore;
using Shoe_WebShop.Models;

namespace Shoe_WebShop.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Running Shoes",
                Description = "Designed for runners, providing support and cushioning for optimal performance."
            },
            new Category
            {
                Id = 2,
                Name = "Women's Shoes",
                Description = "Stylish and comfortable shoes for women."
            },
            new Category
            {
                Id = 3,
                Name = "Men's Shoes",
                Description = "Stylish and comfortable shoes for men."
            }
        );
    }

}
