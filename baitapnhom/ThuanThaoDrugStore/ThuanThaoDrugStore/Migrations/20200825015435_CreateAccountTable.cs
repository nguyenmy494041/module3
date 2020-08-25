using Microsoft.EntityFrameworkCore.Migrations;

namespace ThuanThaoDrugStore.Migrations
{
    public partial class CreateAccountTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    MaTK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    SoDienThoai = table.Column<string>(nullable: false),
                    MatKhau = table.Column<string>(nullable: false),
                    XacnhanMatKhau = table.Column<string>(nullable: false),
                    TinhTp = table.Column<string>(maxLength: 70, nullable: false),
                    QuanHuyen = table.Column<string>(maxLength: 70, nullable: false),
                    PhuongXa = table.Column<string>(maxLength: 70, nullable: false),
                    Diachi = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.MaTK);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
