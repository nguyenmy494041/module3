using BaiKiemTraLan2.Models.Entitiess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
           .HasOne<Category>(p => p.TheLoai)
           .WithMany(c => c.Sachs)
           .HasForeignKey(p => p.MaTheLoai);

            modelBuilder.Entity<Category>().HasData(
              new Category()
              {
                  MaTheLoai = 1,
                  TenTheLoai = "Tiểu Thuyết",

              },
              new Category()
              {
                  MaTheLoai = 2,
                  TenTheLoai = "Trinh Thám",

              },
              new Category()
              {
                  MaTheLoai = 3,
                  TenTheLoai = "Ngôn Tình",

              },
              new Category()
              {
                  MaTheLoai = 4,
                  TenTheLoai = "Hoạt Hình",

              },
              new Category()
              {
                  MaTheLoai = 5,
                  TenTheLoai = "Văn Học",

              }
          );

            modelBuilder.Entity<Book>().HasData(
              new Book()
              {
                  MaSach = 1,
                  TenSach  = "Việt Bắc",                
                  TenTacGia = "Nam Cao",
                  MoTa = "Một cuốn sách hay",
                 NamXuatBan = 2018,
                 Soluong = 12,
                  MaTheLoai = 1
              },
               new Book()
               {
                   MaSach = 2,
                   TenSach = "Tắt Đèn",
                   TenTacGia = "Ngô Tất Tố",
                   MoTa = "Một cuốn sách hay",
                   NamXuatBan = 2019,
                   Soluong = 10,
                   MaTheLoai = 2
               },
                new Book()
                {
                    MaSach = 3,
                    TenSach = "Rừng Xà Nu",
                    TenTacGia = "Nguyên Hồng",
                    MoTa = "Một cuốn sách hay",
                    NamXuatBan = 2018,
                    Soluong = 8,
                    MaTheLoai = 3
                }


          );
        }
        public DbSet<Book> Sachs { get; set; }
        public DbSet<Category> TheLoais { get; set; }
    }
}
