using baikiemtra.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baikiemtra.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocVien>()
           .HasOne<LopHoc>(p => p.Lophoc)
           .WithMany(c => c.HocViens)
           .HasForeignKey(p => p.MaLop);

            modelBuilder.Entity<LopHoc>().HasData(
              new LopHoc()
              {
                  MaLop=1,
                  TenLop = "12A",

              },
              new LopHoc()
              {
                  MaLop = 2,
                  TenLop = "12B",

              },
              new LopHoc()
              {
                  MaLop = 3,
                  TenLop = "12C",

              },
              new LopHoc()
              {
                  MaLop = 4,
                  TenLop = "12D",

              },
              new LopHoc()
              {
                  MaLop = 5,
                  TenLop = "12E",

              }
          );

            modelBuilder.Entity<HocVien>().HasData(
              new HocVien()
              { MaHocVien= 1,
                  HoTen = "Nguyễn VĂn A",
                  Ngaysinh = DateTime.Parse("1999/01/01"),
                  GioiTinh = "Nam",
                  Email = "hatdaunho1404@gmail.com",
                  MaLop = 1
              },
               new HocVien()
               {
                   MaHocVien = 2,
                   HoTen = "Nguyễn VĂn B",
                   Ngaysinh = DateTime.Parse("1999/01/01"),
                   GioiTinh = "Nam",
                   Email = "hatdaunho01@gmail.com",
                   MaLop = 2
               },
                new HocVien()
                {
                    MaHocVien = 3,
                    HoTen = "Nguyễn Thị Năm",
                    Ngaysinh = DateTime.Parse("1999/01/01"),
                    GioiTinh = "Nữ",
                    Email = "hatdaunho1404@gmail.com",
                    MaLop = 3
                }


          );
        }
        public DbSet<HocVien> HocViens { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
    }
}
