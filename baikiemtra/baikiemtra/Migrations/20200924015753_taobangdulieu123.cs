using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace baikiemtra.Migrations
{
    public partial class taobangdulieu123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHocVien", "Email", "GioiTinh", "HoTen", "MaLop", "Ngaysinh" },
                values: new object[] { 1, "hatdaunho1404@gmail.com", "Nam", "Nguyễn VĂn A", 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHocVien", "Email", "GioiTinh", "HoTen", "MaLop", "Ngaysinh" },
                values: new object[] { 2, "hatdaunho01@gmail.com", "Nam", "Nguyễn VĂn B", 2, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "HocViens",
                columns: new[] { "MaHocVien", "Email", "GioiTinh", "HoTen", "MaLop", "Ngaysinh" },
                values: new object[] { 3, "hatdaunho1404@gmail.com", "Nữ", "Nguyễn Thị Năm", 3, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHocVien",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHocVien",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HocViens",
                keyColumn: "MaHocVien",
                keyValue: 3);
        }
    }
}
