using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan3.Migrations
{
    public partial class taobnangjiko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "Banhs");

            migrationBuilder.AddColumn<int>(
                name: "GiaBan",
                table: "Banhs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgaySanXuat",
                table: "Banhs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaBan",
                table: "Banhs");

            migrationBuilder.DropColumn(
                name: "NgaySanXuat",
                table: "Banhs");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "Banhs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
