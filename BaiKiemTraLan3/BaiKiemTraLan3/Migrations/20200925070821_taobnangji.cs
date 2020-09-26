using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan3.Migrations
{
    public partial class taobnangji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TheLoais",
                columns: new[] { "MaTheLoai", "TenTheLoai" },
                values: new object[,]
                {
                    { 1, "Bánh ngọt" },
                    { 2, "Bánh kem" },
                    { 3, "Bánh dừa" },
                    { 4, "Bánh mỳ" },
                    { 5, "Bánh gato" }
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
