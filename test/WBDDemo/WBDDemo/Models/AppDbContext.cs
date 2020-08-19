using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBDDemo.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Fullname = "Chicharito", Email = "hatdaunho@gmail.com", Department = Dept.FW, AvatarPath = "~/images/chicharito.jfif" },
                new Employee() { Id = 2, Fullname = "PaulScholes", Email = "hoangtutocvang@gmail.com", Department = Dept.MF, AvatarPath = "~/images/no_image.jfif" },
                new Employee() { Id = 3, Fullname = "Park Ji Sung", Email = "hatdaunho@gmail.com", Department = Dept.MF, AvatarPath = "~/images/park.jfif" },
                new Employee() { Id = 4, Fullname = "Rafael Da Silva", Email = "hoangtutocvang@gmail.com", Department = Dept.DF, AvatarPath = "~/images/dasilva.jfif" },
                new Employee() { Id = 5, Fullname = "Ferdinand", Email = "hatdaunho@gmail.com", Department = Dept.DF, AvatarPath = "~/images/rio.jfif" },
                new Employee() { Id = 6, Fullname = "Carrick", Email = "hoangtutocvang@gmail.com", Department = Dept.MF, AvatarPath = "~/images/carrick.jfif" }
                );
        }
    }
}
