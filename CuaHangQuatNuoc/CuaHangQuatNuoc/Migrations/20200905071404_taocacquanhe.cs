using Microsoft.EntityFrameworkCore.Migrations;

namespace CuaHangQuatNuoc.Migrations
{
    public partial class taocacquanhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 20, nullable: false),
                    ProductName = table.Column<string>(maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(maxLength: 150, nullable: false),
                    Price = table.Column<long>(maxLength: 20, nullable: false),
                    Size = table.Column<string>(maxLength: 150, nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    TankCapacity = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(maxLength: 50, nullable: false),
                    Wattage = table.Column<int>(nullable: false),
                    Utilities = table.Column<string>(maxLength: 500, nullable: false),
                    Manufactures = table.Column<string>(maxLength: 100, nullable: false),
                    MadeIn = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 10000000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<string>(maxLength: 20, nullable: true),
                    ImageProduct = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<string>(maxLength: 20, nullable: true),
                    Dynamic = table.Column<string>(maxLength: 200, nullable: true),
                    WindSpeed = table.Column<string>(maxLength: 200, nullable: true),
                    WindMode = table.Column<string>(maxLength: 150, nullable: true),
                    Control = table.Column<string>(maxLength: 200, nullable: true),
                    CollingRange = table.Column<string>(maxLength: 200, nullable: true),
                    WindFlow = table.Column<int>(nullable: false),
                    FanCageType = table.Column<string>(maxLength: 100, nullable: true),
                    WaterConsumption = table.Column<string>(maxLength: 200, nullable: true),
                    MachineModel = table.Column<string>(maxLength: 150, nullable: true),
                    FilterTechnology = table.Column<string>(maxLength: 200, nullable: true),
                    NumberFilterCores = table.Column<int>(nullable: false),
                    FilterCapacity = table.Column<int>(nullable: false),
                    Pumping = table.Column<string>(maxLength: 200, nullable: true),
                    Safemode = table.Column<string>(maxLength: 200, nullable: true),
                    Temperature = table.Column<string>(maxLength: 100, nullable: true),
                    WaterPressure = table.Column<float>(nullable: false),
                    WarmUpTime = table.Column<int>(nullable: false),
                    MaxTemperature = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specifications_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
