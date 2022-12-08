using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MatchResults",
                columns: new[] { "Id", "LooserId", "LooserScore", "MatchId", "WinnerId", "WinnerScore" },
                values: new object[,]
                {
                    { 1, 4, 2, 8, 2, 5 },
                    { 2, 6, 1, 9, 4, 3 },
                    { 3, 10, 9, 10, 8, 15 },
                    { 4, 3, 2, 11, 1, 5 },
                    { 5, 5, 4, 12, 2, 8 },
                    { 6, 7, 0, 13, 5, 2 },
                    { 7, 9, 4, 14, 7, 5 },
                    { 8, 3, 8, 15, 2, 12 },
                    { 9, 5, 7, 16, 4, 12 }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "EndDate", "IsCompleted", "StartDate" },
                values: new object[,]
                {
                    { 8, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6118) },
                    { 9, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6119) },
                    { 10, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6121) },
                    { 11, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6122) },
                    { 12, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6124) },
                    { 13, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6126) },
                    { 14, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6127) },
                    { 15, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6129) },
                    { 16, null, true, new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6131) }
                });

            migrationBuilder.InsertData(
                table: "HamsterMatches",
                columns: new[] { "HamsterId", "MatchId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 2, 8 },
                    { 2, 15 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 15 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 16 },
                    { 5, 12 },
                    { 5, 13 },
                    { 5, 16 },
                    { 6, 9 },
                    { 7, 13 },
                    { 7, 14 },
                    { 8, 10 },
                    { 9, 14 },
                    { 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "HamsterMatches",
                keyColumns: new[] { "HamsterId", "MatchId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MatchResults",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Games", "Losses", "Wins" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Games", "Losses" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 14, 40, 18, 119, DateTimeKind.Local).AddTicks(3198));
        }
    }
}
