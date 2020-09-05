using Microsoft.EntityFrameworkCore.Migrations;

namespace CuaHangQuatNuoc.Migrations
{
    public partial class themvirtual12532 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Noiselevel",
                table: "Specifications",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Noiselevel",
                table: "Specifications");
        }
    }
}
