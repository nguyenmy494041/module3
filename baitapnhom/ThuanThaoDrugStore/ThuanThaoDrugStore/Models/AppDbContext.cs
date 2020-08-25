using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuanThaoDrugStore.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<TaiKhoan> Account { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<PhuongXa> PhuongXa { get; set; }

    }
}
