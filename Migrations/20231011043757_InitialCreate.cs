using Microsoft.EntityFrameworkCore.Migrations;

namespace ScrewDepot.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScrewsModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    LengthInMillimeters = table.Column<double>(nullable: false),
                    DiameterInMillimeters = table.Column<double>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    StockQuantity = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrewsModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScrewsModel");
        }
    }
}
