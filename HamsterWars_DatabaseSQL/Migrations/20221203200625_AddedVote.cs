using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedVote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vote", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 3, 21, 6, 25, 194, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.InsertData(
                table: "Vote",
                columns: new[] { "Id", "HamsterId", "MatchId" },
                values: new object[] { 1, 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 2, 19, 36, 22, 118, DateTimeKind.Local).AddTicks(14));
        }
    }
}
