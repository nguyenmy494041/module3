using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTapLon.Migrations
{
    public partial class moilam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ProductPrice",
                table: "Products",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 20);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ProductPrice",
                table: "Products",
                type: "bigint",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(decimal),
                oldMaxLength: 20);
        }
    }
}
