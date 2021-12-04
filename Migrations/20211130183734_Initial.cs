using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProj.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    CollegeProgram = table.Column<string>(nullable: true),
                    YearInProgram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GroupMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "TeamMemberName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development", "Riley Setser", "Sophmore" },
                    { 2, new DateTime(2001, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development", "JP Kelczewski", "Sophmore" },
                    { 3, new DateTime(1976, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development/Game Design", "Chris Royce", "Junior" },
                    { 4, new DateTime(1997, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development", "Cooper Siebert", "Junior" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupMembers");
        }
    }
}
