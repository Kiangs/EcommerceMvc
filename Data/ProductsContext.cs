using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcApp.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName= "Téléviseurs et équipement vidéo",IsActive=true,IsDelete=false },
                new Category() { CategoryId = 2, CategoryName = "Projecteurs", IsActive = true, IsDelete = false },
                new Category() { CategoryId = 3, CategoryName = "Cinémas Maison", IsActive = true, IsDelete = false });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                
            });
            modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(e => e.Category);
        }
    }
}
