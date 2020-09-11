using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToKhaiYte.Models.Entities;


namespace ToKhaiYte.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToKhai>()
                .HasOne<DiaChi>(t => t.DiaChi)
                .WithOne(c => c.ToKhai)
                .HasForeignKey<DiaChi>(c => c.ToKhaiId);

            modelBuilder.Entity<ToKhai>()
               .HasOne<DiLai>(t => t.DiLai)
               .WithOne(c => c.ToKhai)
               .HasForeignKey<DiLai>(c => c.ToKhaiId);

            modelBuilder.Entity<ToKhai>()
              .HasOne<SucKhoe>(t => t.SucKhoe)
              .WithOne(c => c.ToKhai)
              .HasForeignKey<SucKhoe>(c => c.ToKhaiId);

             modelBuilder.Entity<ToKhai>()
             .HasOne<CuaKhau>(i => i.CuaKhau)
             .WithMany(p => p.ToKhais)
             .HasForeignKey(i => i.CuaKhauId);

             modelBuilder.Entity<TinhThanh>()
             .HasOne<QuocGia>(p => p.Quocgia)
              .WithMany(c => c.TinhThanhs)
             .HasForeignKey(p => p.QuocGiaId);

             modelBuilder.Entity<QuanHuyen>()
            .HasOne<TinhThanh>(p => p.TinhThanh)
            .WithMany(c => c.QuanHuyens)
            .HasForeignKey(p => p.TinhThanhId);

             modelBuilder.Entity<PhuongXa>()
            .HasOne<QuanHuyen>(p => p.QuanHuyen)
            .WithMany(c => c.PhuongXas)
            .HasForeignKey(p => p.QuanHuyenId);         

            modelBuilder.Entity<DiaChi>()
          .HasOne<TinhThanh>(p => p.TinhThanh)
          .WithMany(c => c.DiaChis)
          .HasForeignKey(p => p.TinhThanhId);         

        }
        public DbSet<ToKhai> ToKhai { get; set; }
        public DbSet<CuaKhau> CuaKhau { get; set; }
        public DbSet<DiaChi> DiaChi { get; set; }
        public DbSet<SucKhoe> SucKhoe { get; set; }
        public DbSet<DiLai> DiLai { get; set; }
        public DbSet<QuocGia> QuocGia { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<PhuongXa> PhuongXa { get; set; }



    }
}
