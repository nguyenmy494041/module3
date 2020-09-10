using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTapLon.Migrations
{
    public partial class lamlai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ProductPrice",
                table: "Products",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                type: "decimal(18,2)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(long),
                oldMaxLength: 20);
        }
    }
}
