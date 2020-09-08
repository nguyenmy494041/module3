using Microsoft.EntityFrameworkCore.Migrations;

namespace BaiTapLon.Migrations
{
    public partial class CreateTable : Migration
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
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(maxLength: 20, nullable: false),
                    ProductName = table.Column<string>(maxLength: 150, nullable: false),
                    ProductPrice = table.Column<long>(maxLength: 20, nullable: false),
                    Size = table.Column<string>(maxLength: 150, nullable: false),
                    Weight = table.Column<float>(nullable: false),
                    TankCapacity = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(maxLength: 50, nullable: false),
                    Wattage = table.Column<int>(nullable: false),
                    Utilities = table.Column<string>(maxLength: 500, nullable: false),
                    Manufactures = table.Column<string>(maxLength: 100, nullable: false),
                    MadeIn = table.Column<string>(maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dynamic = table.Column<string>(maxLength: 200, nullable: true),
                    WindSpeed = table.Column<string>(maxLength: 200, nullable: true),
                    WindMode = table.Column<string>(maxLength: 150, nullable: true),
                    Control = table.Column<string>(maxLength: 200, nullable: true),
                    CollingRange = table.Column<string>(maxLength: 200, nullable: true),
                    WindFlow = table.Column<int>(nullable: true),
                    FanCageType = table.Column<string>(maxLength: 100, nullable: true),
                    Noiselevel = table.Column<string>(maxLength: 100, nullable: true),
                    WaterConsumption = table.Column<string>(maxLength: 200, nullable: true),
                    MachineModel = table.Column<string>(maxLength: 150, nullable: true),
                    FilterTechnology = table.Column<string>(maxLength: 200, nullable: true),
                    NumberFilterCores = table.Column<int>(nullable: true),
                    FilterCapacity = table.Column<int>(nullable: true),
                    Pumping = table.Column<string>(maxLength: 200, nullable: true),
                    Safemode = table.Column<string>(maxLength: 200, nullable: true),
                    Temperature = table.Column<string>(maxLength: 100, nullable: true),
                    WaterPressure = table.Column<float>(nullable: true),
                    WarmUpTime = table.Column<int>(nullable: true),
                    MaxTemperature = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Specifications");
        }
    }
}
