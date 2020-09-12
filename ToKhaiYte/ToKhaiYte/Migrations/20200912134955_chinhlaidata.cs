using Microsoft.EntityFrameworkCore.Migrations;

namespace ToKhaiYte.Migrations
{
    public partial class chinhlaidata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SoCMND",
                table: "ToKhai",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "DiaChi",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DiaChi",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "SoCMND",
                table: "ToKhai",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<long>(
                name: "SoDienThoai",
                table: "DiaChi",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "DiaChi",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
