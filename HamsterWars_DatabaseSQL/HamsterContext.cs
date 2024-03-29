﻿using Microsoft.EntityFrameworkCore;
using HamsterWars_DatabaseSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;


namespace HamsterWars_DatabaseSQL
{
    public class HamsterContext : DbContext
    {
        public DbSet<Hamster> Hamsters { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<MatchResult> MatchResults { get; set; }
        public DbSet<HamsterMatches> HamsterMatches { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            
        //.UseSqlServer(@"Server=DESKTOP-T2GL85N\SQLEXPRESS2019;Database=HamsterWars_MN_2022;Trusted_Connection=True;Encrypt=False");
        .UseSqlServer(@"Server=DESKTOP-MBPUR5V\SQLEXPRESS;Database=HamsterWars_MN_2022;Trusted_Connection=True;Encrypt=False");
        //.UseSqlServer(@"Server=LAPTOP-JG820AED\SQLEXPRESS;Database=HamsterWars_MN_2022;Trusted_Connection=True;Encrypt=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hamster>()
                    .HasMany(b => b.Matches)
                    .WithMany(a => a.Contestants)
                    .UsingEntity<HamsterMatches>(ab => ab.HasOne<Match>().WithMany(),
                    ab => ab.HasOne<Hamster>().WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    );

            modelBuilder.Entity<MatchResult>()
                .HasOne(x => x.Winner)
                .WithMany(y=> y.MatchResultsWinner)
                .HasForeignKey(a => a.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MatchResult>()
                .HasOne(x => x.Looser)
                .WithMany(y => y.MatchResultsLooser)
                .HasForeignKey(a => a.LooserId)
                .OnDelete(DeleteBehavior.Restrict);

            //Seed
            modelBuilder.Entity<Hamster>().HasData(
                new Hamster { Id = 1, Age = 2, FavFood = "Carrot", ImgName = "hamster-1.jpg",
                    Name = "Destroyer of Worlds", Games = 3, Losses = 1, Loves = "Killing babies", Wins = 2 },
                new Hamster { Id = 2, Age = 1, FavFood = "Cucumber", ImgName = "hamster-2.jpg",
                    Name = "Savior of Worlds", Games = 5, Losses = 2, Loves = "Helping elderly", Wins = 3 },
                new Hamster { Id = 3, Age = 0, FavFood = "Apple", ImgName = "hamster-3.jpg",
                    Name = "Protector of the Wastelands", Games = 5, Losses = 2, Loves = "Confronting Evil", Wins = 3 },
                new Hamster { Id = 4, Age = 4, FavFood = "Pepper", ImgName = "hamster-4.jpg",
                    Name = "Grand Hamster", Games = 5, Losses = 1, Loves = "Sleeping", Wins = 4 },
                new Hamster { Id = 5, Age = 2, FavFood = "Banana", ImgName = "hamster-5.jpg",
                    Name = "Yellow Devil", Games = 4, Losses = 2, Loves = "Yellow things", Wins = 2 },
                new Hamster { Id = 6, Age = 1, FavFood = "Snickers", ImgName = "hamster-6.jpg",
                    Name = "Wingman", Games = 1, Losses = 1, Loves = "Helping others", Wins = 0 },
                new Hamster { Id = 7, Age = 1, FavFood = "Sugar", ImgName = "hamster-7.jpg",
                    Name = "Rincewind", Games = 4, Losses = 3, Loves = "Reading books", Wins = 1 },
                new Hamster { Id = 8, Age = 7, FavFood = "Candy", ImgName = "hamster-8.jpg",
                    Name = "Red dwarf", Games = 2, Losses = 1, Loves = "Small things", Wins = 1 },
                new Hamster { Id = 9, Age = 4, FavFood = "Ice cream", ImgName = "hamster-9.jpg",
                    Name = "Snowden", Games = 2, Losses = 2, Loves = "IoT", Wins = 0 },
                new Hamster { Id = 10, Age = 3, FavFood = "Ice cream", ImgName = "hamster-10.jpg",
                    Name = "Ice Queen", Games = 2, Losses = 1, Loves = "Snowmen", Wins = 1 },
                new Hamster { Id = 11, Age = 2, FavFood = "Spinach", ImgName = "hamster-11.jpg",
                    Name = "Glissa the Traitor", Games = 0, Losses = 0, Loves = "Atrefacts", Wins = 0 },
                new Hamster { Id = 12, Age = 1, FavFood = "Grass", ImgName = "hamster-12.jpg",
                    Name = "Courser of Kruphix", Games = 0, Losses = 0, Loves = "Boats", Wins = 0 },
                new Hamster { Id = 13, Age = 0, FavFood = "Cinnamon", ImgName = "hamster-13.jpg",
                    Name = "Lys Alana Huntsmaster", Games = 0, Losses = 0, Loves = "Dogs", Wins = 0 },
                new Hamster { Id = 14, Age = 1, FavFood = "Rats", ImgName = "hamster-14.jpg",
                    Name = "Vraska the Unseen", Games = 0, Losses = 0, Loves = "Snakes", Wins = 0 },
                new Hamster { Id = 15, Age = 2, FavFood = "Steaks", ImgName = "hamster-15.jpg",
                    Name = "Harald, King of Hamsters", Games = 0, Losses = 0, Loves = "Sleep", Wins = 0 },
                new Hamster { Id = 16, Age = 3, FavFood = "Wine", ImgName = "hamster-16.jpg",
                    Name = "Lathril, Blade of the Night", Games = 0, Losses = 0, Loves = "Sneaking around", Wins = 0 },
                new Hamster { Id = 17, Age = 3, FavFood = "Crackers", ImgName = "hamster-17.jpg",
                    Name = "Sheoldred, the Apocalypse", Games = 0, Losses = 0, Loves = "Tears of her enemies", Wins = 0 }
                );

            modelBuilder.Entity<Match>().HasData(
                new Match { Id = 1, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 2, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 3, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 4, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 5, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 6, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 7, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 8, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 9, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 10, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 11, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 12, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 13, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 14, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 15, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now },
                new Match { Id = 16, StartDate = DateTime.Now, IsCompleted = true, EndDate = DateTime.Now }
                );

            modelBuilder.Entity<HamsterMatches>().HasData(
                new HamsterMatches { HamsterId= 1, MatchId= 1,},
                new HamsterMatches { HamsterId = 2, MatchId = 1 },
                new HamsterMatches { HamsterId = 4, MatchId = 2, },
                new HamsterMatches { HamsterId = 7, MatchId = 2, },
                new HamsterMatches { HamsterId = 3, MatchId = 3, },
                new HamsterMatches { HamsterId = 1, MatchId = 3, },
                new HamsterMatches { HamsterId = 5, MatchId = 4, },
                new HamsterMatches { HamsterId = 8, MatchId = 4, },
                new HamsterMatches { HamsterId = 4, MatchId = 5, },
                new HamsterMatches { HamsterId = 9, MatchId = 5, },
                new HamsterMatches { HamsterId = 10, MatchId = 6, },
                new HamsterMatches { HamsterId = 2, MatchId = 6, },

                new HamsterMatches { HamsterId = 8, MatchId = 7, },
                new HamsterMatches { HamsterId = 3, MatchId = 7, },
                new HamsterMatches { HamsterId = 2, MatchId = 8, },
                new HamsterMatches { HamsterId = 4, MatchId = 8, },
                new HamsterMatches { HamsterId = 4, MatchId = 9, },
                new HamsterMatches { HamsterId = 6, MatchId = 9, },
                new HamsterMatches { HamsterId = 8, MatchId = 10, },
                new HamsterMatches { HamsterId = 10, MatchId = 10, },
                new HamsterMatches { HamsterId = 1, MatchId = 11, },
                new HamsterMatches { HamsterId = 3, MatchId = 11, },
                new HamsterMatches { HamsterId = 3, MatchId = 12, },
                new HamsterMatches { HamsterId = 5, MatchId = 12, },
                new HamsterMatches { HamsterId = 5, MatchId = 13, },
                new HamsterMatches { HamsterId = 7, MatchId = 13, },
                new HamsterMatches { HamsterId = 7, MatchId = 14, },
                new HamsterMatches { HamsterId = 9, MatchId = 14, },
                new HamsterMatches { HamsterId = 2, MatchId = 15, },
                new HamsterMatches { HamsterId = 3, MatchId = 15, },
                new HamsterMatches { HamsterId = 4, MatchId = 16, },
                new HamsterMatches { HamsterId = 5, MatchId = 16, }

                );

            modelBuilder.Entity<MatchResult>().HasData(
                new MatchResult { Id = 1, MatchId = 8, WinnerId = 2, LooserId = 4, WinnerScore = 5, LooserScore = 2 },
                new MatchResult { Id = 2, MatchId = 9, WinnerId = 4, LooserId = 6, WinnerScore = 3, LooserScore = 1 },
                new MatchResult { Id = 3, MatchId = 10, WinnerId = 8, LooserId = 10, WinnerScore = 15, LooserScore = 9 },
                new MatchResult { Id = 4, MatchId = 11, WinnerId = 1, LooserId = 3, WinnerScore = 5, LooserScore = 2 },
                new MatchResult { Id = 5, MatchId = 12, WinnerId = 2, LooserId = 5, WinnerScore = 8, LooserScore = 4 },
                new MatchResult { Id = 6, MatchId = 13, WinnerId = 5, LooserId = 7, WinnerScore = 2, LooserScore = 0 },
                new MatchResult { Id = 7, MatchId = 14, WinnerId = 7, LooserId = 9, WinnerScore = 5, LooserScore = 4 },
                new MatchResult { Id = 8, MatchId = 15, WinnerId = 2, LooserId = 3, WinnerScore = 12, LooserScore = 8 },
                new MatchResult { Id = 9, MatchId = 16, WinnerId = 4, LooserId = 5, WinnerScore = 12, LooserScore = 7 },
                new MatchResult { Id = 10, MatchId = 7, WinnerId = 3, LooserId = 8, WinnerScore = 12, LooserScore = 7 },
                new MatchResult { Id = 11, MatchId = 6, WinnerId = 10, LooserId = 2, WinnerScore = 7, LooserScore = 3 },
                new MatchResult { Id = 12, MatchId = 5, WinnerId = 4, LooserId = 9, WinnerScore = 3, LooserScore = 1 },
                new MatchResult { Id = 13, MatchId = 4, WinnerId = 5, LooserId = 8, WinnerScore = 3, LooserScore = 1 },
                new MatchResult { Id = 14, MatchId = 3, WinnerId = 3, LooserId = 1, WinnerScore = 11, LooserScore = 9 },
                new MatchResult { Id = 15, MatchId = 2, WinnerId = 4, LooserId = 7, WinnerScore = 6, LooserScore = 5 },
                new MatchResult { Id = 16, MatchId = 1, WinnerId = 1, LooserId = 2, WinnerScore = 6, LooserScore = 1 }
                );
        }
    }
}
