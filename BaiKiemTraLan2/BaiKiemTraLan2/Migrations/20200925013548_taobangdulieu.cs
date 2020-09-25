using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan2.Migrations
{
    public partial class taobangdulieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TheLoais",
                columns: new[] { "MaTheLoai", "TenTheLoai" },
                values: new object[,]
                {
                    { 1, "Tiểu Thuyết" },
                    { 2, "Trinh Thám" },
                    { 3, "Ngôn Tình" },
                    { 4, "Hoạt Hình" },
                    { 5, "Văn Học" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TheLoais",
                keyColumn: "MaTheLoai",
                keyValue: 5);
        }
    }
}
