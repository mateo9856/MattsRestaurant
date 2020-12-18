using Microsoft.EntityFrameworkCore.Migrations;

namespace MattsRestaurant.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dinners",
                columns: table => new
                {
                    DinnerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Allergens = table.Column<string>(nullable: true),
                    DinnerOfTheDay = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    DinnerCategory = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CuisineType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dinners", x => x.DinnerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dinners");
        }
    }
}
