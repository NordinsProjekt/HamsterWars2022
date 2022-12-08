using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class LatestUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 21, 10, 32, 46, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "HamsterId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults",
                column: "LooserId",
                principalTable: "Hamsters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults",
                column: "WinnerId",
                principalTable: "Hamsters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Games", "Wins" },
                values: new object[] { 2, 2 });

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

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 8, 0, 58, 25, 464, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 1,
                column: "HamsterId",
                value: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults",
                column: "LooserId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults",
                column: "WinnerId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
