using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToKhaiYte.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuaKhau",
                columns: table => new
                {
                    CuaKhauId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCuaKhau = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaKhau", x => x.CuaKhauId);
                });

            migrationBuilder.CreateTable(
                name: "QuocGia",
                columns: table => new
                {
                    QuocGiaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuocGia = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuocGia", x => x.QuocGiaId);
                });

            migrationBuilder.CreateTable(
                name: "ToKhai",
                columns: table => new
                {
                    ToKhaiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(maxLength: 100, nullable: false),
                    Namsinh = table.Column<int>(nullable: false),
                    Gioitinh = table.Column<string>(maxLength: 50, nullable: false),
                    Quoctich = table.Column<int>(maxLength: 150, nullable: false),
                    SoCMND = table.Column<long>(nullable: false),
                    CuaKhauId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToKhai", x => x.ToKhaiId);
                    table.ForeignKey(
                        name: "FK_ToKhai_CuaKhau_CuaKhauId",
                        column: x => x.CuaKhauId,
                        principalTable: "CuaKhau",
                        principalColumn: "CuaKhauId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    TinhThanhId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhThanh = table.Column<string>(maxLength: 100, nullable: false),
                    TinhHayThanhPho = table.Column<string>(maxLength: 100, nullable: false),
                    MaBuuDien = table.Column<string>(maxLength: 10, nullable: false),
                    QuocGiaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.TinhThanhId);
                    table.ForeignKey(
                        name: "FK_TinhThanh_QuocGia_QuocGiaId",
                        column: x => x.QuocGiaId,
                        principalTable: "QuocGia",
                        principalColumn: "QuocGiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiLai",
                columns: table => new
                {
                    DiLaiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhuongTienDiLai = table.Column<string>(maxLength: 300, nullable: false),
                    SoHieuPhuongTien = table.Column<string>(maxLength: 100, nullable: false),
                    SoGhe = table.Column<string>(maxLength: 50, nullable: false),
                    NgayKhoiHanh = table.Column<DateTime>(nullable: false),
                    NgayNhapCanh = table.Column<DateTime>(nullable: false),
                    QuocGiaKhoiHanh = table.Column<int>(nullable: false),
                    TinhKhoiHanh = table.Column<string>(maxLength: 100, nullable: false),
                    QuocGiaDen = table.Column<int>(nullable: false),
                    TinhDen = table.Column<int>(nullable: false),
                    NoiTungDen = table.Column<string>(maxLength: 500, nullable: false),
                    ToKhaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiLai", x => x.DiLaiId);
                    table.ForeignKey(
                        name: "FK_DiLai_ToKhai_ToKhaiId",
                        column: x => x.ToKhaiId,
                        principalTable: "ToKhai",
                        principalColumn: "ToKhaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SucKhoe",
                columns: table => new
                {
                    SucKhoeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<bool>(nullable: false),
                    Sot = table.Column<bool>(nullable: false),
                    KhoTho = table.Column<bool>(nullable: false),
                    DauHong = table.Column<bool>(nullable: false),
                    BuonNon = table.Column<bool>(nullable: false),
                    TieuChay = table.Column<bool>(nullable: false),
                    XuatHuyetNgoaiDa = table.Column<bool>(nullable: false),
                    NoiBanNgoaiDa = table.Column<bool>(nullable: false),
                    DanhSachVacxin = table.Column<string>(maxLength: 200, nullable: false),
                    TiepXucDongVat = table.Column<bool>(nullable: false),
                    TiepXucNguoiBenh = table.Column<bool>(nullable: false),
                    ToKhaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SucKhoe", x => x.SucKhoeId);
                    table.ForeignKey(
                        name: "FK_SucKhoe_ToKhai_ToKhaiId",
                        column: x => x.ToKhaiId,
                        principalTable: "ToKhai",
                        principalColumn: "ToKhaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    DiaChiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TinhThanhId = table.Column<int>(nullable: false),
                    QuanHuyenId = table.Column<int>(nullable: false),
                    PhuongXaId = table.Column<int>(nullable: false),
                    SoNha = table.Column<string>(maxLength: 150, nullable: false),
                    SoDienThoai = table.Column<long>(nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    ToKhaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChi", x => x.DiaChiId);
                    table.ForeignKey(
                        name: "FK_DiaChi_TinhThanh_TinhThanhId",
                        column: x => x.TinhThanhId,
                        principalTable: "TinhThanh",
                        principalColumn: "TinhThanhId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaChi_ToKhai_ToKhaiId",
                        column: x => x.ToKhaiId,
                        principalTable: "ToKhai",
                        principalColumn: "ToKhaiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    QuanHuyenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuanHuyen = table.Column<string>(maxLength: 100, nullable: false),
                    QuanHayHuyen = table.Column<string>(maxLength: 100, nullable: false),
                    TinhThanhId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyen", x => x.QuanHuyenId);
                    table.ForeignKey(
                        name: "FK_QuanHuyen_TinhThanh_TinhThanhId",
                        column: x => x.TinhThanhId,
                        principalTable: "TinhThanh",
                        principalColumn: "TinhThanhId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhuongXa",
                columns: table => new
                {
                    PhuongXaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhuongXa = table.Column<string>(maxLength: 100, nullable: false),
                    PhuongHayXa = table.Column<string>(maxLength: 30, nullable: false),
                    TinhThanhId = table.Column<int>(nullable: false),
                    QuanHuyenId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongXa", x => x.PhuongXaId);
                    table.ForeignKey(
                        name: "FK_PhuongXa_QuanHuyen_QuanHuyenId",
                        column: x => x.QuanHuyenId,
                        principalTable: "QuanHuyen",
                        principalColumn: "QuanHuyenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_TinhThanhId",
                table: "DiaChi",
                column: "TinhThanhId");

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_ToKhaiId",
                table: "DiaChi",
                column: "ToKhaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiLai_ToKhaiId",
                table: "DiLai",
                column: "ToKhaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhuongXa_QuanHuyenId",
                table: "PhuongXa",
                column: "QuanHuyenId");

            migrationBuilder.CreateIndex(
                name: "IX_QuanHuyen_TinhThanhId",
                table: "QuanHuyen",
                column: "TinhThanhId");

            migrationBuilder.CreateIndex(
                name: "IX_SucKhoe_ToKhaiId",
                table: "SucKhoe",
                column: "ToKhaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TinhThanh_QuocGiaId",
                table: "TinhThanh",
                column: "QuocGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ToKhai_CuaKhauId",
                table: "ToKhai",
                column: "CuaKhauId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaChi");

            migrationBuilder.DropTable(
                name: "DiLai");

            migrationBuilder.DropTable(
                name: "PhuongXa");

            migrationBuilder.DropTable(
                name: "SucKhoe");

            migrationBuilder.DropTable(
                name: "QuanHuyen");

            migrationBuilder.DropTable(
                name: "ToKhai");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "CuaKhau");

            migrationBuilder.DropTable(
                name: "QuocGia");
        }
    }
}
