using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 4, 4, "Pepper", 0, "hamster-4.jpg", 0, "Sleeping", "Grand Hamster", 0 },
                    { 5, 2, "Banana", 0, "hamster-5.jpg", 0, "Yellow things", "Yellow Devil", 0 },
                    { 6, 1, "Snickers", 0, "hamster-6.jpg", 0, "Helping others", "Wingman", 0 },
                    { 7, 1, "Sugar", 0, "hamster-7.jpg", 0, "Reading books", "Rincewind", 0 },
                    { 8, 7, "Candy", 0, "hamster-8.jpg", 0, "Small things", "Red dwarf", 0 },
                    { 9, 4, "Ice cream", 0, "hamster-9.jpg", 0, "IoT", "Snowden", 0 },
                    { 10, 3, "Ice cream", 0, "hamster-10.jpg", 0, "Snowmen", "Ice Queen", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "EndDate", "IsCompleted", "StartDate" },
                values: new object[,]
                {
                    { 2, null, true, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2679) },
                    { 3, null, false, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2681) },
                    { 4, null, false, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2683) },
                    { 5, null, true, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2685) },
                    { 6, null, true, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2687) },
                    { 7, null, true, new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2688) }
                });

            migrationBuilder.UpdateData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 1,
                column: "HamsterId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Vote",
                columns: new[] { "Id", "HamsterId", "MatchId" },
                values: new object[,]
                {
                    { 2, 4, 2 },
                    { 3, 7, 2 },
                    { 4, 7, 2 },
                    { 5, 7, 2 },
                    { 6, 7, 2 },
                    { 7, 4, 2 },
                    { 8, 4, 2 },
                    { 9, 7, 2 },
                    { 10, 4, 5 },
                    { 11, 10, 6 },
                    { 12, 8, 7 }
                });

            migrationBuilder.InsertData(
                table: "HamsterMatches",
                columns: new[] { "HamsterId", "MatchId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 6 },
                    { 3, 3 },
                    { 3, 7 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 4 },
                    { 7, 2 },
                    { 8, 4 },
                    { 8, 7 },
                    { 9, 5 },
                    { 10, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 4, 0, 1, 56, 75, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Vote",
                keyColumn: "Id",
                keyValue: 1,
                column: "HamsterId",
                value: 2);
        }
    }
}
