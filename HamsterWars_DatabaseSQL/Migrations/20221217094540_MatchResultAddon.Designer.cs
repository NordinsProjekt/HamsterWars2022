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
    [Migration("20221217094540_MatchResultAddon")]
    partial class MatchResultAddon
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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
                            Games = 1,
                            ImgName = "hamster-1.jpg",
                            IsDeleted = false,
                            Losses = 0,
                            Loves = "Killing babies",
                            Name = "Destroyer of Worlds",
                            Wins = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            FavFood = "Cucumber",
                            Games = 3,
                            ImgName = "hamster-2.jpg",
                            IsDeleted = false,
                            Losses = 0,
                            Loves = "Helping elderly",
                            Name = "Savior of Worlds",
                            Wins = 3
                        },
                        new
                        {
                            Id = 3,
                            Age = 0,
                            FavFood = "Apple",
                            Games = 3,
                            ImgName = "hamster-3.jpg",
                            IsDeleted = false,
                            Losses = 2,
                            Loves = "Confronting Evil",
                            Name = "Protector of the Wastelands",
                            Wins = 1
                        },
                        new
                        {
                            Id = 4,
                            Age = 4,
                            FavFood = "Pepper",
                            Games = 3,
                            ImgName = "hamster-4.jpg",
                            IsDeleted = false,
                            Losses = 1,
                            Loves = "Sleeping",
                            Name = "Grand Hamster",
                            Wins = 2
                        },
                        new
                        {
                            Id = 5,
                            Age = 2,
                            FavFood = "Banana",
                            Games = 3,
                            ImgName = "hamster-5.jpg",
                            IsDeleted = false,
                            Losses = 2,
                            Loves = "Yellow things",
                            Name = "Yellow Devil",
                            Wins = 1
                        },
                        new
                        {
                            Id = 6,
                            Age = 1,
                            FavFood = "Snickers",
                            Games = 1,
                            ImgName = "hamster-6.jpg",
                            IsDeleted = false,
                            Losses = 1,
                            Loves = "Helping others",
                            Name = "Wingman",
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 1,
                            FavFood = "Sugar",
                            Games = 2,
                            ImgName = "hamster-7.jpg",
                            IsDeleted = false,
                            Losses = 1,
                            Loves = "Reading books",
                            Name = "Rincewind",
                            Wins = 1
                        },
                        new
                        {
                            Id = 8,
                            Age = 7,
                            FavFood = "Candy",
                            Games = 1,
                            ImgName = "hamster-8.jpg",
                            IsDeleted = false,
                            Losses = 0,
                            Loves = "Small things",
                            Name = "Red dwarf",
                            Wins = 1
                        },
                        new
                        {
                            Id = 9,
                            Age = 4,
                            FavFood = "Ice cream",
                            Games = 1,
                            ImgName = "hamster-9.jpg",
                            IsDeleted = false,
                            Losses = 1,
                            Loves = "IoT",
                            Name = "Snowden",
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 3,
                            FavFood = "Ice cream",
                            Games = 1,
                            ImgName = "hamster-10.jpg",
                            IsDeleted = false,
                            Losses = 1,
                            Loves = "Snowmen",
                            Name = "Ice Queen",
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
                        },
                        new
                        {
                            HamsterId = 4,
                            MatchId = 2
                        },
                        new
                        {
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            HamsterId = 3,
                            MatchId = 3
                        },
                        new
                        {
                            HamsterId = 1,
                            MatchId = 3
                        },
                        new
                        {
                            HamsterId = 5,
                            MatchId = 4
                        },
                        new
                        {
                            HamsterId = 8,
                            MatchId = 4
                        },
                        new
                        {
                            HamsterId = 4,
                            MatchId = 5
                        },
                        new
                        {
                            HamsterId = 9,
                            MatchId = 5
                        },
                        new
                        {
                            HamsterId = 10,
                            MatchId = 6
                        },
                        new
                        {
                            HamsterId = 2,
                            MatchId = 6
                        },
                        new
                        {
                            HamsterId = 8,
                            MatchId = 7
                        },
                        new
                        {
                            HamsterId = 3,
                            MatchId = 7
                        },
                        new
                        {
                            HamsterId = 2,
                            MatchId = 8
                        },
                        new
                        {
                            HamsterId = 4,
                            MatchId = 8
                        },
                        new
                        {
                            HamsterId = 4,
                            MatchId = 9
                        },
                        new
                        {
                            HamsterId = 6,
                            MatchId = 9
                        },
                        new
                        {
                            HamsterId = 8,
                            MatchId = 10
                        },
                        new
                        {
                            HamsterId = 10,
                            MatchId = 10
                        },
                        new
                        {
                            HamsterId = 1,
                            MatchId = 11
                        },
                        new
                        {
                            HamsterId = 3,
                            MatchId = 11
                        },
                        new
                        {
                            HamsterId = 3,
                            MatchId = 12
                        },
                        new
                        {
                            HamsterId = 5,
                            MatchId = 12
                        },
                        new
                        {
                            HamsterId = 5,
                            MatchId = 13
                        },
                        new
                        {
                            HamsterId = 7,
                            MatchId = 13
                        },
                        new
                        {
                            HamsterId = 7,
                            MatchId = 14
                        },
                        new
                        {
                            HamsterId = 9,
                            MatchId = 14
                        },
                        new
                        {
                            HamsterId = 2,
                            MatchId = 15
                        },
                        new
                        {
                            HamsterId = 3,
                            MatchId = 15
                        },
                        new
                        {
                            HamsterId = 4,
                            MatchId = 16
                        },
                        new
                        {
                            HamsterId = 5,
                            MatchId = 16
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

                    b.Property<int?>("TId")
                        .HasColumnType("int");

                    b.Property<int?>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsCompleted = false,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2320)
                        },
                        new
                        {
                            Id = 2,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2347)
                        },
                        new
                        {
                            Id = 3,
                            IsCompleted = false,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2349)
                        },
                        new
                        {
                            Id = 4,
                            IsCompleted = false,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2351)
                        },
                        new
                        {
                            Id = 5,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2352)
                        },
                        new
                        {
                            Id = 6,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2354)
                        },
                        new
                        {
                            Id = 7,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2355)
                        },
                        new
                        {
                            Id = 8,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2357)
                        },
                        new
                        {
                            Id = 9,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2359)
                        },
                        new
                        {
                            Id = 10,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2361)
                        },
                        new
                        {
                            Id = 11,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2362)
                        },
                        new
                        {
                            Id = 12,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2364)
                        },
                        new
                        {
                            Id = 13,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2365)
                        },
                        new
                        {
                            Id = 14,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2367)
                        },
                        new
                        {
                            Id = 15,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2369)
                        },
                        new
                        {
                            Id = 16,
                            IsCompleted = true,
                            StartDate = new DateTime(2022, 12, 17, 10, 45, 39, 819, DateTimeKind.Local).AddTicks(2372)
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.MatchResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LooserId")
                        .HasColumnType("int");

                    b.Property<int>("LooserScore")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LooserId");

                    b.HasIndex("MatchId")
                        .IsUnique();

                    b.HasIndex("WinnerId");

                    b.ToTable("MatchResults");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LooserId = 4,
                            LooserScore = 2,
                            MatchId = 8,
                            WinnerId = 2,
                            WinnerScore = 5
                        },
                        new
                        {
                            Id = 2,
                            LooserId = 6,
                            LooserScore = 1,
                            MatchId = 9,
                            WinnerId = 4,
                            WinnerScore = 3
                        },
                        new
                        {
                            Id = 3,
                            LooserId = 10,
                            LooserScore = 9,
                            MatchId = 10,
                            WinnerId = 8,
                            WinnerScore = 15
                        },
                        new
                        {
                            Id = 4,
                            LooserId = 3,
                            LooserScore = 2,
                            MatchId = 11,
                            WinnerId = 1,
                            WinnerScore = 5
                        },
                        new
                        {
                            Id = 5,
                            LooserId = 5,
                            LooserScore = 4,
                            MatchId = 12,
                            WinnerId = 2,
                            WinnerScore = 8
                        },
                        new
                        {
                            Id = 6,
                            LooserId = 7,
                            LooserScore = 0,
                            MatchId = 13,
                            WinnerId = 5,
                            WinnerScore = 2
                        },
                        new
                        {
                            Id = 7,
                            LooserId = 9,
                            LooserScore = 4,
                            MatchId = 14,
                            WinnerId = 7,
                            WinnerScore = 5
                        },
                        new
                        {
                            Id = 8,
                            LooserId = 3,
                            LooserScore = 8,
                            MatchId = 15,
                            WinnerId = 2,
                            WinnerScore = 12
                        },
                        new
                        {
                            Id = 9,
                            LooserId = 5,
                            LooserScore = 7,
                            MatchId = 16,
                            WinnerId = 4,
                            WinnerScore = 12
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Tournament", b =>
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

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
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

                    b.ToTable("Votes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HamsterId = 2,
                            MatchId = 1
                        },
                        new
                        {
                            Id = 2,
                            HamsterId = 4,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 3,
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 4,
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 5,
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 6,
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 7,
                            HamsterId = 4,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 8,
                            HamsterId = 4,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 9,
                            HamsterId = 7,
                            MatchId = 2
                        },
                        new
                        {
                            Id = 10,
                            HamsterId = 4,
                            MatchId = 5
                        },
                        new
                        {
                            Id = 11,
                            HamsterId = 10,
                            MatchId = 6
                        },
                        new
                        {
                            Id = 12,
                            HamsterId = 8,
                            MatchId = 7
                        });
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.HamsterMatches", b =>
                {
                    b.HasOne("HamsterWars_DatabaseSQL.Models.Hamster", null)
                        .WithMany()
                        .HasForeignKey("HamsterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamsterWars_DatabaseSQL.Models.Match", null)
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Match", b =>
                {
                    b.HasOne("HamsterWars_DatabaseSQL.Models.Tournament", "Tour")
                        .WithMany("Matches")
                        .HasForeignKey("TourId");

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.MatchResult", b =>
                {
                    b.HasOne("HamsterWars_DatabaseSQL.Models.Hamster", "Looser")
                        .WithMany("MatchResultsLooser")
                        .HasForeignKey("LooserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HamsterWars_DatabaseSQL.Models.Match", null)
                        .WithOne("Result")
                        .HasForeignKey("HamsterWars_DatabaseSQL.Models.MatchResult", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HamsterWars_DatabaseSQL.Models.Hamster", "Winner")
                        .WithMany("MatchResultsWinner")
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Looser");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Hamster", b =>
                {
                    b.Navigation("MatchResultsLooser");

                    b.Navigation("MatchResultsWinner");
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Match", b =>
                {
                    b.Navigation("Result");
                });

            modelBuilder.Entity("HamsterWars_DatabaseSQL.Models.Tournament", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
