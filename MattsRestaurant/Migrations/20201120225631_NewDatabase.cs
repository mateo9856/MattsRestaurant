using Microsoft.EntityFrameworkCore.Migrations;

namespace MattsRestaurant.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/images/PizzaCapriciosa.png");

            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/images/Skewers.png");

            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/images/Dumplings.png");

            migrationBuilder.InsertData(
                table: "dinners",
                columns: new[] { "DinnerId", "Allergens", "CuisineType", "Description", "DinnerCategory", "DinnerOfTheDay", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "Eggs, Milk, Celary, Mustard", 2, "A Japanese dish consisting of small balls or rolls of vinegar-flavoured cold rice served with a garnish of vegetables, egg, or raw seafood.", "Japanesse Kitchen", false, "~/images/Sushi.png", "Japanesse Sushi", 18.0 },
                    { 5, "Gluten, Milk, Lactose, Eggs", 0, "An Italian dish consisting of lasagne baked with meat or vegetables and a cheese sauce.", "Baked Dishes", false, "~/images/Lasagne.png", "Lasagne Bolognesse", 12.0 },
                    { 6, "Gluten, Eggs, Lactose", 1, "Chicken breasts stuffed with cheese, butter and spinnach", "Main Dishes", false, "~/images/De volaille.png", "De voliaille", 18.0 },
                    { 7, "Gluten, Eggs, Lactose", 0, "Pesto has become a catch all word used to describe many different things today. It originated in Italy as a mortar-and-pestle ground, coarse sauce made of basil, pine nuts, garlic, Parmesan, and olive oil. ", "Italian Food", false, "~/images/Basil Pesto.png", "Basil Pesto", 22.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "dinners",
                keyColumn: "DinnerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "");
        }
    }
}
