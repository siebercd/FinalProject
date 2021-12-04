using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProj.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(nullable: true),
                    StartYear = table.Column<int>(nullable: false),
                    Expensive = table.Column<string>(nullable: true),
                    TotalSpent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupHobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GroupHobbies",
                columns: new[] { "Id", "Expensive", "HobbyName", "StartYear", "TotalSpent" },
                values: new object[,]
                {
                    { 1, "Yes", "Music Producing", 2017, 500 },
                    { 2, "Yes", "Golf", 2018, 300 },
                    { 3, "Yes", "Gaming", 1995, 5000 },
                    { 4, "Yes", "Gaming", 2010, 2000 }
                });

            migrationBuilder.UpdateData(
                table: "GroupMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearInProgram",
                value: "Sophomore");

            migrationBuilder.UpdateData(
                table: "GroupMembers",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearInProgram",
                value: "Sophomore");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupHobbies");

            migrationBuilder.UpdateData(
                table: "GroupMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "YearInProgram",
                value: "Sophmore");

            migrationBuilder.UpdateData(
                table: "GroupMembers",
                keyColumn: "Id",
                keyValue: 2,
                column: "YearInProgram",
                value: "Sophmore");
        }
    }
}
