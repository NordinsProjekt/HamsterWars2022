﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars_DatabaseSQL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 1, 2, "Carrot", 0, "hamster-1.jpg", 0, "Killing babies", "Destroyer of Worlds", 0 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 2, 1, "Cucumber", 0, "hamster-2.jpg", 0, "Helping elderly", "Savior of Worlds", 0 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 3, 0, "Apple", 0, "hamster-3.jpg", 0, "Confronting Evil", "Protector of the Wastelands", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
