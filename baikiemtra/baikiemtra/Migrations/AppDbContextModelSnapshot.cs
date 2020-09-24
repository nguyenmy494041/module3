﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using baikiemtra.Models;

namespace baikiemtra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("baikiemtra.Models.Entities.HocVien", b =>
                {
                    b.Property<int>("MaHocVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MaLop")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.HasKey("MaHocVien");

                    b.HasIndex("MaLop");

                    b.ToTable("HocViens");

                    b.HasData(
                        new
                        {
                            MaHocVien = 1,
                            Email = "hatdaunho1404@gmail.com",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn VĂn A",
                            MaLop = 1,
                            Ngaysinh = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            MaHocVien = 2,
                            Email = "hatdaunho01@gmail.com",
                            GioiTinh = "Nam",
                            HoTen = "Nguyễn VĂn B",
                            MaLop = 2,
                            Ngaysinh = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            MaHocVien = 3,
                            Email = "hatdaunho1404@gmail.com",
                            GioiTinh = "Nữ",
                            HoTen = "Nguyễn Thị Năm",
                            MaLop = 3,
                            Ngaysinh = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("baikiemtra.Models.Entities.LopHoc", b =>
                {
                    b.Property<int>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaLop");

                    b.ToTable("LopHocs");

                    b.HasData(
                        new
                        {
                            MaLop = 1,
                            TenLop = "12A"
                        },
                        new
                        {
                            MaLop = 2,
                            TenLop = "12B"
                        },
                        new
                        {
                            MaLop = 3,
                            TenLop = "12C"
                        },
                        new
                        {
                            MaLop = 4,
                            TenLop = "12D"
                        },
                        new
                        {
                            MaLop = 5,
                            TenLop = "12E"
                        });
                });

            modelBuilder.Entity("baikiemtra.Models.Entities.HocVien", b =>
                {
                    b.HasOne("baikiemtra.Models.Entities.LopHoc", "Lophoc")
                        .WithMany("HocViens")
                        .HasForeignKey("MaLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
