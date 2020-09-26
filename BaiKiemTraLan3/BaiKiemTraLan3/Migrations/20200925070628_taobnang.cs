using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan3.Migrations
{
    public partial class taobnang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    MaTheLoai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTheLoai = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.MaTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "Banhs",
                columns: table => new
                {
                    MaBanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBanh = table.Column<string>(maxLength: 100, nullable: false),
                    ThanhPhan = table.Column<string>(maxLength: 100, nullable: false),
                    HanSuDung = table.Column<string>(maxLength: 100, nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    DaXoa = table.Column<bool>(nullable: false),
                    MaTheLoai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banhs", x => x.MaBanh);
                    table.ForeignKey(
                        name: "FK_Banhs_TheLoais_MaTheLoai",
                        column: x => x.MaTheLoai,
                        principalTable: "TheLoais",
                        principalColumn: "MaTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banhs_MaTheLoai",
                table: "Banhs",
                column: "MaTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banhs");

            migrationBuilder.DropTable(
                name: "TheLoais");
        }
    }
}
