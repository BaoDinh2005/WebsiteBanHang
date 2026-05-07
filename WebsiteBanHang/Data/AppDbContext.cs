using Microsoft.EntityFrameworkCore;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } // Khai báo bảng Category

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tạo dữ liệu mẫu cho Category
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Điện thoại" },
                new Category { Id = 2, Name = "Laptop" }
            );
                     
            // Tạo dữ liệu mẫu cho Product
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 15", Price = 20000000, CategoryId = 1 },
                new Product { Id = 2, Name = "Dell XPS", Price = 30000000, CategoryId = 2 },
                new Product { Id = 3, Name = "Lenovo Legion", Price = 25000000, CategoryId = 2 },
                new Product { Id = 4, Name = "MacBook Air", Price = 22000000, CategoryId = 2 }
            );
        }
    }
}