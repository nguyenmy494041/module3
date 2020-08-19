using Microsoft.EntityFrameworkCore.Migrations;

namespace WBDDemo.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "Fullname" },
                values: new object[,]
                {
                    { 1, "~/images/chicharito.jfif", 3, "hatdaunho@gmail.com", "Chicharito" },
                    { 2, "~/images/no_image.jfif", 2, "hoangtutocvang@gmail.com", "PaulScholes" },
                    { 3, "~/images/park.jfif", 2, "hatdaunho@gmail.com", "Park Ji Sung" },
                    { 4, "~/images/dasilva.jfif", 1, "hoangtutocvang@gmail.com", "Rafael Da Silva" },
                    { 5, "~/images/rio.jfif", 1, "hatdaunho@gmail.com", "Ferdinand" },
                    { 6, "~/images/carrick.jfif", 2, "hoangtutocvang@gmail.com", "Carrick" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
