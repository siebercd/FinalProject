using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProj.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavoriteITSubject = table.Column<string>(nullable: true),
                    FavoriteLanguage = table.Column<string>(nullable: true),
                    YearsInIT = table.Column<string>(nullable: true),
                    CareerGoal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CareerGoal", "FavoriteITSubject", "FavoriteLanguage", "YearsInIT" },
                values: new object[,]
                {
                    { 1, "Yes", "Programming", "C#", "2" },
                    { 2, "Yes", "Programming", "C#", "2" },
                    { 3, "Software Analyst", "Human Computer Interaction", "C#", "25" },
                    { 4, "QA/Dev", "Database Management", "C#", "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
