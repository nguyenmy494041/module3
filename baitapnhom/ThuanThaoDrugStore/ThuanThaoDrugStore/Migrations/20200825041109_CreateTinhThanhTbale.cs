using Microsoft.EntityFrameworkCore.Migrations;

namespace ThuanThaoDrugStore.Migrations
{
    public partial class CreateTinhThanhTbale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    Id_QuanHuyen = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuanHuyen = table.Column<string>(maxLength: 100, nullable: false),
                    MaQuanHuyen = table.Column<string>(maxLength: 20, nullable: false),
                    Id_TinhThanh = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyen", x => x.Id_QuanHuyen);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuanHuyen");
        }
    }
}
