using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTournaments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfConsestants",
                table: "Tournaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 17, 13, 16, 17, 782, DateTimeKind.Local).AddTicks(682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfConsestants",
                table: "Tournaments");

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
        }
    }
}
