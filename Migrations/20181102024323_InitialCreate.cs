using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CFLv2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Week = table.Column<string>(nullable: true),
                    GameDate = table.Column<DateTime>(nullable: false),
                    AwayTeam = table.Column<string>(nullable: true),
                    HomeTeam = table.Column<string>(nullable: true),
                    AwayPoints = table.Column<int>(nullable: false),
                    HomePoints = table.Column<int>(nullable: false),
                    Attendance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeasonID = table.Column<int>(nullable: false),
                    SeasonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Standings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamID = table.Column<int>(nullable: false),
                    Rank = table.Column<int>(nullable: false),
                    LongName = table.Column<string>(nullable: true),
                    GP = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Loses = table.Column<int>(nullable: false),
                    Ties = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    PointsFor = table.Column<int>(nullable: false),
                    PointsAgainst = table.Column<int>(nullable: false),
                    HomeWins = table.Column<int>(nullable: false),
                    HomeRecord = table.Column<string>(nullable: true),
                    AwayWins = table.Column<int>(nullable: false),
                    AwayRecord = table.Column<string>(nullable: true),
                    InDiv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abbrev = table.Column<string>(nullable: true),
                    LongName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Stadium = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ID", "Attendance", "AwayPoints", "AwayTeam", "GameDate", "HomePoints", "HomeTeam", "Week" },
                values: new object[,]
                {
                    { 1, 25458, 33, "EDM", new DateTime(2018, 6, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 30, "WPG", "1" },
                    { 2, 29788, 19, "TOR", new DateTime(2018, 6, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 27, "SSK", "1" },
                    { 3, 23717, 14, "HAM", new DateTime(2018, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), 28, "CGY", "1" },
                    { 4, 20182, 10, "MTL", new DateTime(2018, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), 22, "BC", "1" },
                    { 5, 24224, 17, "SSK", new DateTime(2018, 6, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 40, "OTT", "2" },
                    { 6, 19498, 56, "WPG", new DateTime(2018, 6, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 10, "MTL", "2" },
                    { 7, 31334, 38, "HAM", new DateTime(2018, 6, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 21, "EDM", "2" },
                    { 8, 16450, 41, "CGY", new DateTime(2018, 6, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 7, "TOR", "2" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "ID", "SeasonID", "SeasonName" },
                values: new object[] { 60, 2018, "2018" });

            migrationBuilder.InsertData(
                table: "Standings",
                columns: new[] { "ID", "AwayRecord", "AwayWins", "GP", "HomeRecord", "HomeWins", "InDiv", "LongName", "Loses", "Points", "PointsAgainst", "PointsFor", "Rank", "TeamID", "Ties", "Wins" },
                values: new object[,]
                {
                    { 9, "", 0, 0, "", 0, "", "Montreal", 0, 0, 0, 0, 0, 9, 0, 0 },
                    { 8, "", 0, 0, "", 0, "", "Ottawa", 0, 0, 0, 0, 0, 8, 0, 0 },
                    { 7, "", 0, 0, "", 0, "", "Hamilton", 0, 0, 0, 0, 0, 7, 0, 0 },
                    { 6, "", 0, 0, "", 0, "", "Toronto", 0, 0, 0, 0, 0, 6, 0, 0 },
                    { 5, "", 0, 0, "", 0, "", "Winnipeg", 0, 0, 0, 0, 0, 5, 0, 0 },
                    { 4, "", 0, 0, "", 0, "", "Saskatchewan", 0, 0, 0, 0, 0, 4, 0, 0 },
                    { 3, "", 0, 0, "", 0, "", "Edmonton", 0, 0, 0, 0, 0, 3, 0, 0 },
                    { 2, "", 0, 0, "", 0, "", "Edmonton", 0, 0, 0, 0, 0, 2, 0, 0 },
                    { 1, "", 0, 0, "", 0, "", "BC Lions", 0, 0, 0, 0, 0, 1, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Abbrev", "City", "LongName", "Stadium" },
                values: new object[,]
                {
                    { 1, "BC", "Vancouver", "BC Lions", "BC Place" },
                    { 2, "EDM", "Edmonton", "Edmonton Eskimos", "Commonweath Stadium" },
                    { 3, "CGY", "Calgary", "Calgary Stampeders", "McMahon Stadium" },
                    { 4, "SSK", "Regina", "Saskatchewan Roughriders", "Mosaic Stadium" },
                    { 5, "WPG", "Winnipeg", "Winnipeg Blue Bombers", "Investors Group Field" },
                    { 6, "TOR", "Toronto", "Toronto Argonauts", "BMO Field" },
                    { 7, "HAM", "Hamilton", "Hamilton Tiger-Cats", "Tim Hortons Field" },
                    { 8, "OTT", "Ottawa", "Ottawa Redblacks", "TD Place Stadium" },
                    { 9, "MTL", "Montreal", "Montreal Alouettes", "Percival Molson Memorial Stadium" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Standings");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
