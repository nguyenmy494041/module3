using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan2.Migrations
{
    public partial class taobangdulieusach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "MaTheLoai", "MoTa", "NamXuatBan", "Soluong", "TenSach", "TenTacGia" },
                values: new object[] { 1, 1, "Một cuốn sách hay", 2018, 12, "Việt Bắc", "Nam Cao" });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "MaTheLoai", "MoTa", "NamXuatBan", "Soluong", "TenSach", "TenTacGia" },
                values: new object[] { 2, 2, "Một cuốn sách hay", 2019, 10, "Tắt Đèn", "Ngô Tất Tố" });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "MaTheLoai", "MoTa", "NamXuatBan", "Soluong", "TenSach", "TenTacGia" },
                values: new object[] { 3, 3, "Một cuốn sách hay", 2018, 8, "Rừng Xà Nu", "Nguyên Hồng" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sachs",
                keyColumn: "MaSach",
                keyValue: 3);
        }
    }
}
