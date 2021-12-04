using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProj.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavFoods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavoriteFood = table.Column<string>(nullable: true),
                    SecondFav = table.Column<string>(nullable: true),
                    LeastFav = table.Column<string>(nullable: true),
                    MealOfTheDay = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavFoods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FavFoods",
                columns: new[] { "Id", "FavoriteFood", "LeastFav", "MealOfTheDay", "SecondFav" },
                values: new object[,]
                {
                    { 1, "Hamburgers", "Tomato", "Dinner", "Breakfast Sandwich" },
                    { 2, "Chipotle Burrito", "Cupcakes", "Breakfast", "Bosco Sticks" },
                    { 3, "Chicken and Broccoli Alfredo", "Hot Dogs", "Dinner", "Shrimp Scampi" },
                    { 4, "Chicken Wings", "Sushi", "Lunch", "Burgers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavFoods");
        }
    }
}
