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
      
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .HasOne<Specification>(p => p.Specification)
        //        .WithOne(s => s.Product)
        //        .HasForeignKey<Specification>(s => s.ProductId);

        //    modelBuilder.Entity<Image>()
        //     .HasOne<Product>(i => i.Product)
        //     .WithMany(p => p.Images)
        //     .HasForeignKey(i => i.ProductId);

        //    modelBuilder.Entity<Product>()
        //    .HasOne<Category>(p => p.Category)
        //    .WithMany(c => c.Products)
        //    .HasForeignKey(p => p.CategoryId);
        //}


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
