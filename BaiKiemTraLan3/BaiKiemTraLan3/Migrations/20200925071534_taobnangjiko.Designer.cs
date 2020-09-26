﻿// <auto-generated />
using System;
using BaiKiemTraLan3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BaiKiemTraLan3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200925071534_taobnangjiko")]
    partial class taobnangjiko
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BaiKiemTraLan3.Models.Entitiesss.Cake", b =>
                {
                    b.Property<int>("MaBanh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<string>("HanSuDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MaTheLoai")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySanXuat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenBanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ThanhPhan")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaBanh");

                    b.HasIndex("MaTheLoai");

                    b.ToTable("Banhs");
                });

            modelBuilder.Entity("BaiKiemTraLan3.Models.Entitiesss.Category", b =>
                {
                    b.Property<int>("MaTheLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaTheLoai");

                    b.ToTable("TheLoais");

                    b.HasData(
                        new
                        {
                            MaTheLoai = 1,
                            TenTheLoai = "Bánh ngọt"
                        },
                        new
                        {
                            MaTheLoai = 2,
                            TenTheLoai = "Bánh kem"
                        },
                        new
                        {
                            MaTheLoai = 3,
                            TenTheLoai = "Bánh dừa"
                        },
                        new
                        {
                            MaTheLoai = 4,
                            TenTheLoai = "Bánh mỳ"
                        },
                        new
                        {
                            MaTheLoai = 5,
                            TenTheLoai = "Bánh gato"
                        });
                });

            modelBuilder.Entity("BaiKiemTraLan3.Models.Entitiesss.Cake", b =>
                {
                    b.HasOne("BaiKiemTraLan3.Models.Entitiesss.Category", "TheLoai")
                        .WithMany("Banhs")
                        .HasForeignKey("MaTheLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
