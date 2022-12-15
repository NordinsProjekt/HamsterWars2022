using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    /// <inheritdoc />
    public partial class MoreModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HamsterMatches_Hamsters_HamsterId",
                table: "HamsterMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "MatchResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LooserId",
                table: "MatchResults",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Hamsters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6806), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6837), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6840), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6841), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6843), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6844), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6846), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6847), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6849), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6850), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6852), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6854), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6856), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6857), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6859), null, null });

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "StartDate", "TId", "TourId" },
                values: new object[] { new DateTime(2022, 12, 15, 13, 42, 47, 870, DateTimeKind.Local).AddTicks(6860), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TourId",
                table: "Matches",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_HamsterMatches_Hamsters_HamsterId",
                table: "HamsterMatches",
                column: "HamsterId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Tournaments_TourId",
                table: "Matches",
                column: "TourId",
                principalTable: "Tournaments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults",
                column: "LooserId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults",
                column: "WinnerId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HamsterMatches_Hamsters_HamsterId",
                table: "HamsterMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Tournaments_TourId",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_LooserId",
                table: "MatchResults");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchResults_Hamsters_WinnerId",
                table: "MatchResults");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TourId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Hamsters");

            migrationBuilder.AlterColumn<int>(
                name: "WinnerId",
                table: "MatchResults",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LooserId",
                table: "MatchResults",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_HamsterMatches_Hamsters_HamsterId",
                table: "HamsterMatches",
                column: "HamsterId",
                principalTable: "Hamsters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
