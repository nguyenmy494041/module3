using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan2.Migrations
{
    public partial class taobang : Migration
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
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(maxLength: 100, nullable: false),
                    TenTacGia = table.Column<string>(maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(maxLength: 200, nullable: false),
                    NamXuatBan = table.Column<int>(nullable: false),
                    Soluong = table.Column<int>(nullable: false),
                    MaTheLoai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sachs_TheLoais_MaTheLoai",
                        column: x => x.MaTheLoai,
                        principalTable: "TheLoais",
                        principalColumn: "MaTheLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_MaTheLoai",
                table: "Sachs",
                column: "MaTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "TheLoais");
        }
    }
}
