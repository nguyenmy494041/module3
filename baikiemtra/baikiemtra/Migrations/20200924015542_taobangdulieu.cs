using Microsoft.EntityFrameworkCore.Migrations;

namespace baikiemtra.Migrations
{
    public partial class taobangdulieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LopHocs",
                columns: new[] { "MaLop", "TenLop" },
                values: new object[,]
                {
                    { 1, "12A" },
                    { 2, "12B" },
                    { 3, "12C" },
                    { 4, "12D" },
                    { 5, "12E" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 5);
        }
    }
}
