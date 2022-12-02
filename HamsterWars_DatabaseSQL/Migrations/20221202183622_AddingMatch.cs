using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars_DatabaseSQL.Migrations
{
    public partial class AddingMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HamsterMatches",
                columns: table => new
                {
                    HamsterId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HamsterMatches", x => new { x.HamsterId, x.MatchId });
                    table.ForeignKey(
                        name: "FK_HamsterMatches_Hamsters_HamsterId",
                        column: x => x.HamsterId,
                        principalTable: "Hamsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HamsterMatches_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "EndDate", "IsCompleted", "StartDate" },
                values: new object[] { 1, null, false, new DateTime(2022, 12, 2, 19, 36, 22, 118, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.InsertData(
                table: "HamsterMatches",
                columns: new[] { "HamsterId", "MatchId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "HamsterMatches",
                columns: new[] { "HamsterId", "MatchId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_HamsterMatches_MatchId",
                table: "HamsterMatches",
                column: "MatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HamsterMatches");

            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
