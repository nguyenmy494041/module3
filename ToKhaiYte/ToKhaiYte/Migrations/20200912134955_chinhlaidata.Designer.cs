﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToKhaiYte.Models;

namespace ToKhaiYte.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200912134955_chinhlaidata")]
    partial class chinhlaidata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToKhaiYte.Models.Entities.CuaKhau", b =>
                {
                    b.Property<int>("CuaKhauId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenCuaKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CuaKhauId");

                    b.ToTable("CuaKhau");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.DiLai", b =>
                {
                    b.Property<int>("DiLaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayKhoiHanh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhapCanh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiTungDen")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("PhuongTienDiLai")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("QuocGiaDen")
                        .HasColumnType("int");

                    b.Property<int>("QuocGiaKhoiHanh")
                        .HasColumnType("int");

                    b.Property<string>("SoGhe")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SoHieuPhuongTien")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TinhDen")
                        .HasColumnType("int");

                    b.Property<string>("TinhKhoiHanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ToKhaiId")
                        .HasColumnType("int");

                    b.HasKey("DiLaiId");

                    b.HasIndex("ToKhaiId")
                        .IsUnique();

                    b.ToTable("DiLai");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.DiaChi", b =>
                {
                    b.Property<int>("DiaChiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("PhuongXaId")
                        .HasColumnType("int");

                    b.Property<int>("QuanHuyenId")
                        .HasColumnType("int");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<string>("SoNha")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("TinhThanhId")
                        .HasColumnType("int");

                    b.Property<int>("ToKhaiId")
                        .HasColumnType("int");

                    b.HasKey("DiaChiId");

                    b.HasIndex("TinhThanhId");

                    b.HasIndex("ToKhaiId")
                        .IsUnique();

                    b.ToTable("DiaChi");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.PhuongXa", b =>
                {
                    b.Property<int>("PhuongXaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhuongHayXa")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("QuanHuyenId")
                        .HasColumnType("int");

                    b.Property<string>("TenPhuongXa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TinhThanhId")
                        .HasColumnType("int");

                    b.HasKey("PhuongXaId");

                    b.HasIndex("QuanHuyenId");

                    b.ToTable("PhuongXa");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.QuanHuyen", b =>
                {
                    b.Property<int>("QuanHuyenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuanHayHuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TenQuanHuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TinhThanhId")
                        .HasColumnType("int");

                    b.HasKey("QuanHuyenId");

                    b.HasIndex("TinhThanhId");

                    b.ToTable("QuanHuyen");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.QuocGia", b =>
                {
                    b.Property<int>("QuocGiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenQuocGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("QuocGiaId");

                    b.ToTable("QuocGia");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.SucKhoe", b =>
                {
                    b.Property<int>("SucKhoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BuonNon")
                        .HasColumnType("bit");

                    b.Property<string>("DanhSachVacxin")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("DauHong")
                        .HasColumnType("bit");

                    b.Property<bool>("Ho")
                        .HasColumnType("bit");

                    b.Property<bool>("KhoTho")
                        .HasColumnType("bit");

                    b.Property<bool>("NoiBanNgoaiDa")
                        .HasColumnType("bit");

                    b.Property<bool>("Sot")
                        .HasColumnType("bit");

                    b.Property<bool>("TiepXucDongVat")
                        .HasColumnType("bit");

                    b.Property<bool>("TiepXucNguoiBenh")
                        .HasColumnType("bit");

                    b.Property<bool>("TieuChay")
                        .HasColumnType("bit");

                    b.Property<int>("ToKhaiId")
                        .HasColumnType("int");

                    b.Property<bool>("XuatHuyetNgoaiDa")
                        .HasColumnType("bit");

                    b.HasKey("SucKhoeId");

                    b.HasIndex("ToKhaiId")
                        .IsUnique();

                    b.ToTable("SucKhoe");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.TinhThanh", b =>
                {
                    b.Property<int>("TinhThanhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaBuuDien")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("QuocGiaId")
                        .HasColumnType("int");

                    b.Property<string>("TenTinhThanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TinhHayThanhPho")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("TinhThanhId");

                    b.HasIndex("QuocGiaId");

                    b.ToTable("TinhThanh");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.ToKhai", b =>
                {
                    b.Property<int>("ToKhaiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuaKhauId")
                        .HasColumnType("int");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Namsinh")
                        .HasColumnType("int");

                    b.Property<int>("Quoctich")
                        .HasColumnType("int");

                    b.Property<string>("SoCMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("ToKhaiId");

                    b.HasIndex("CuaKhauId");

                    b.ToTable("ToKhai");
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.DiLai", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.ToKhai", "ToKhai")
                        .WithOne("DiLai")
                        .HasForeignKey("ToKhaiYte.Models.Entities.DiLai", "ToKhaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.DiaChi", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.TinhThanh", "TinhThanh")
                        .WithMany("DiaChis")
                        .HasForeignKey("TinhThanhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToKhaiYte.Models.Entities.ToKhai", "ToKhai")
                        .WithOne("DiaChi")
                        .HasForeignKey("ToKhaiYte.Models.Entities.DiaChi", "ToKhaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.PhuongXa", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.QuanHuyen", "QuanHuyen")
                        .WithMany("PhuongXas")
                        .HasForeignKey("QuanHuyenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.QuanHuyen", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.TinhThanh", "TinhThanh")
                        .WithMany("QuanHuyens")
                        .HasForeignKey("TinhThanhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.SucKhoe", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.ToKhai", "ToKhai")
                        .WithOne("SucKhoe")
                        .HasForeignKey("ToKhaiYte.Models.Entities.SucKhoe", "ToKhaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.TinhThanh", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.QuocGia", "Quocgia")
                        .WithMany("TinhThanhs")
                        .HasForeignKey("QuocGiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToKhaiYte.Models.Entities.ToKhai", b =>
                {
                    b.HasOne("ToKhaiYte.Models.Entities.CuaKhau", "CuaKhau")
                        .WithMany("ToKhais")
                        .HasForeignKey("CuaKhauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
