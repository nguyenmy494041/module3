using Microsoft.EntityFrameworkCore.Migrations;

namespace ThuanThaoDrugStore.Migrations
{
    public partial class CreateQuanHUyenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhuongXa",
                columns: table => new
                {
                    Id_PhuongXa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhuongXa = table.Column<string>(maxLength: 50, nullable: false),
                    MaPhuongXa = table.Column<string>(maxLength: 20, nullable: false),
                    Id_TinhThanh = table.Column<int>(nullable: false),
                    Id_QuanHuyen = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongXa", x => x.Id_PhuongXa);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    Id_TinhThanh = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinhThanh = table.Column<string>(maxLength: 50, nullable: false),
                    MaTinhThanh = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.Id_TinhThanh);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhuongXa");

            migrationBuilder.DropTable(
                name: "TinhThanh");
        }
    }
}
