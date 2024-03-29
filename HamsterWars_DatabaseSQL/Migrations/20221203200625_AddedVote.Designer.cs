﻿// <auto-generated />
using System;
using HamsterWars_DatabaseSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HamsterWarsDatabaseSQL.Migrations
{
    [DbContext(typeof(HamsterContext))]
    [Migration("20221203200625_AddedVote")]
    partial class AddedVote
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Hamster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.HamsterMatches", b =>
                {
                    b.Property<int>("HamsterId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("HamsterId", "MatchId");

                    b.HasIndex("MatchId");

                    b.ToTable("HamsterMatches");

                    b.HasData(
                        new
                        {
                            HamsterId = 1,
                            MatchId = 1
                        },
                        new
                        {
                            HamsterId = 2,
                            MatchId = 1
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCompleted = false,
                            StartDate = new DateTime(2022, 12, 3, 21, 6, 25, 194, DateTimeKind.Local).AddTicks(5126)
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HamsterId")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vote");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HamsterId = 2,
                            MatchId = 1
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.HamsterMatches", b =>
                {
                    b.HasOne("HamsterWars_DatabaseSQL.Models.Hamster", null)
                        .WithMany()
                        .HasForeignKey("HamsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HamsterWars_DatabaseSQL.Models.Match", null)
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
