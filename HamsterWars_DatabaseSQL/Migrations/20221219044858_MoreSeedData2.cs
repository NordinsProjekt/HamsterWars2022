using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "IsDeleted", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 11, 2, "Spinach", 0, "hamster-11.jpg", false, 0, "Atrefacts", "Glissa the Traitor", 0 },
                    { 12, 1, "Grass", 0, "hamster-12.jpg", false, 0, "Boats", "Courser of Kruphix", 0 },
                    { 13, 0, "Cinnamon", 0, "hamster-13.jpg", false, 0, "Dogs", "Lys Alana Huntsmaster", 0 },
                    { 14, 1, "Rats", 0, "hamster-14.jpg", false, 0, "Snakes", "Vraska the Unseen", 0 },
                    { 15, 2, "Steaks", 0, "hamster-15.jpg", false, 0, "Sleep", "Harald, King of Hamsters", 0 },
                    { 16, 3, "Wine", 0, "hamster-16.jpg", false, 0, "Sneaking around", "Lathril, Blade of the Night", 0 },
                    { 17, 3, "Crackers", 0, "hamster-17.jpg", false, 0, "Tears of her enemies", "Sheoldred, the Apocalypse", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                column: "StartDate",
                value: new DateTime(2022, 12, 19, 5, 48, 58, 26, DateTimeKind.Local).AddTicks(6420));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 17);

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
    }
}
