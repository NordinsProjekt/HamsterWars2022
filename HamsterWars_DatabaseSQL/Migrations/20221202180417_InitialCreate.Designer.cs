﻿// <auto-generated />
using HamsterWars_DatabaseSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamsterWars_DatabaseSQL.Migrations
{
    [DbContext(typeof(HamsterContext))]
    [Migration("20221202180417_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FavFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Loves")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hamsters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            FavFood = "Carrot",
                            Games = 0,
                            ImgName = "hamster-1.jpg",
                            Losses = 0,
                            Loves = "Killing babies",
                            Name = "Destroyer of Worlds",
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            FavFood = "Cucumber",
                            Games = 0,
                            ImgName = "hamster-2.jpg",
                            Losses = 0,
                            Loves = "Helping elderly",
                            Name = "Savior of Worlds",
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            FavFood = "Apple",
                            Games = 0,
                            ImgName = "hamster-3.jpg",
                            Losses = 0,
                            Loves = "Confronting Evil",
                            Name = "Protector of the Wastelands",
                            Wins = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
