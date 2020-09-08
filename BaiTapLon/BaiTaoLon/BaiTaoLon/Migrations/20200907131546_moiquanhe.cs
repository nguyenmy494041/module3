using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTapLon.Migrations
{
    public partial class moiquanhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Specifications",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Images",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.DropIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Specifications");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Images");
        }
    }
}
