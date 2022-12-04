using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 4, 0, 1, 56, 75, DateTimeKind.Local).AddTicks(9270));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 3, 21, 6, 25, 194, DateTimeKind.Local).AddTicks(5126));
        }
    }
}
