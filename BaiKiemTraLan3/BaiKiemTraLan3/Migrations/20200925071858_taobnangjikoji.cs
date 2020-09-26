using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiKiemTraLan3.Migrations
{
    public partial class taobnangjikoji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banhs",
                columns: new[] { "MaBanh", "DaXoa", "GiaBan", "HanSuDung", "MaTheLoai", "NgaySanXuat", "TenBanh", "ThanhPhan" },
                values: new object[] { 1, false, 16000, "3 tháng", 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh quy", "Bột mỳ, trứng" });

            migrationBuilder.InsertData(
                table: "Banhs",
                columns: new[] { "MaBanh", "DaXoa", "GiaBan", "HanSuDung", "MaTheLoai", "NgaySanXuat", "TenBanh", "ThanhPhan" },
                values: new object[] { 2, false, 150000, "3 tháng", 2, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh sinh nhật", "Bột mỳ, trứng" });

            migrationBuilder.InsertData(
                table: "Banhs",
                columns: new[] { "MaBanh", "DaXoa", "GiaBan", "HanSuDung", "MaTheLoai", "NgaySanXuat", "TenBanh", "ThanhPhan" },
                values: new object[] { 3, false, 16000, "3 tháng", 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh dừa bến tre", "Bột gạo, trứng" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banhs",
                keyColumn: "MaBanh",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banhs",
                keyColumn: "MaBanh",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Banhs",
                keyColumn: "MaBanh",
                keyValue: 3);
        }
    }
}
