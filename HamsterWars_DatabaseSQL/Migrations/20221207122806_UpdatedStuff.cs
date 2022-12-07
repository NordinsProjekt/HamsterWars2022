using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Vote",
                table: "Vote");

            migrationBuilder.RenameTable(
                name: "Vote",
                newName: "Votes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Votes",
                table: "Votes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 7, 13, 28, 6, 736, DateTimeKind.Local).AddTicks(1278));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Votes",
                table: "Votes");

            migrationBuilder.RenameTable(
                name: "Votes",
                newName: "Vote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vote",
                table: "Vote",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 6, 11, 51, 14, 661, DateTimeKind.Local).AddTicks(2688));
        }
    }
}
