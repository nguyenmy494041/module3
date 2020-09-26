using BaiKiemTraLan3.Models.Entitiesss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan3.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>()
           .HasOne<Category>(p => p.TheLoai)
           .WithMany(c => c.Banhs)
           .HasForeignKey(p => p.MaTheLoai);

            modelBuilder.Entity<Category>().HasData(
              new Category()
              {
                  MaTheLoai = 1,
                  TenTheLoai = "Bánh ngọt",

              },
              new Category()
              {
                  MaTheLoai = 2,
                  TenTheLoai = "Bánh kem",

              },
              new Category()
              {
                  MaTheLoai = 3,
                  TenTheLoai = "Bánh dừa",

              },
              new Category()
              {
                  MaTheLoai = 4,
                  TenTheLoai = "Bánh mỳ",

              },
              new Category()
              {
                  MaTheLoai = 5,
                  TenTheLoai = "Bánh gato",

              }
          );

            modelBuilder.Entity<Cake>().HasData(
              new Cake()
              {
                  MaBanh = 1,
                  TenBanh = "Bánh quy",
                  ThanhPhan = "Bột mỳ, trứng",
                  HanSuDung = "3 tháng",
                  NgaySanXuat = DateTime.Parse("2020/01/01"),
                  GiaBan = 16000,
                  DaXoa = false,
                  MaTheLoai = 1
              },
              new Cake()
              {
                  MaBanh = 2,
                  TenBanh = "Bánh sinh nhật",
                  ThanhPhan = "Bột mỳ, trứng",
                  HanSuDung = "3 tháng",
                  NgaySanXuat = DateTime.Parse("2020/02/01"),
                  GiaBan = 150000,
                  DaXoa = false,
                  MaTheLoai = 2
              },
              new Cake()
              {
                  MaBanh = 3,
                  TenBanh = "Bánh dừa bến tre",
                  ThanhPhan = "Bột gạo, trứng",
                  HanSuDung = "3 tháng",
                  NgaySanXuat = DateTime.Parse("2020/01/01"),
                  GiaBan = 16000,
                  DaXoa = false,
                  MaTheLoai = 3
              }
          );
        }
        public DbSet<Cake> Banhs { get; set; }
        public DbSet<Category> TheLoais { get; set; }
    }
}
