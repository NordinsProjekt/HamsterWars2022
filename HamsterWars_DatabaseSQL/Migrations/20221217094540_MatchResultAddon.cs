using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class MatchResultAddon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.CreateIndex(
                name: "IX_MatchResults_MatchId",
                table: "MatchResults",
                column: "MatchId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Matches_MatchId",
                table: "MatchResults",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Matches_MatchId",
                table: "MatchResults");

            migrationBuilder.DropIndex(
                name: "IX_MatchResults_MatchId",
                table: "MatchResults");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6860));
        }
    }
}
