using CuaHangQuatNuoc.Models.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuaHangQuatNuoc.Models.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HOANGLINH;Database=SteamFan;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne<Specification>(p =>p.specification)
                .WithOne(s => s.product)
                .HasForeignKey<Specification>(s => s.ProductId);

            modelBuilder.Entity<Image>()
             .HasOne<Product>(i => i.product)
             .WithMany(p => p.images)
             .HasForeignKey(i => i.ProductId);

            modelBuilder.Entity<Product>()
            .HasOne<Category>(p => p.category)
            .WithMany(c => c.products)
            .HasForeignKey(p => p.CategoryId);
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
