using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
        .UseSqlServer(@"Server=DESKTOP-MBPUR5V\SQLEXPRESS;Database=HamsterWars_MN_2022;Trusted_Connection=True;Encrypt=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hamster>()
                    .HasMany(b => b.Matches)
                    .WithMany(a => a.Contestants)
                    .UsingEntity<HamsterMatches>(ab => ab.HasOne<Match>().WithMany(),
                    ab => ab.HasOne<Hamster>().WithMany());
            //Seed
            modelBuilder.Entity<Hamster>().HasData(
                new Hamster { Id = 1, Age = 2, FavFood = "Carrot", ImgName = "hamster-1.jpg",
                    Name = "Destroyer of Worlds", Games = 0, Losses = 0, Loves = "Killing babies", Wins = 0 },
                new Hamster { Id = 2, Age = 1, FavFood = "Cucumber", ImgName = "hamster-2.jpg",
                    Name = "Savior of Worlds", Games = 0, Losses = 0, Loves = "Helping elderly", Wins = 0 },
                new Hamster { Id = 3, Age = 0, FavFood = "Apple", ImgName = "hamster-3.jpg",
                    Name = "Protector of the Wastelands", Games = 0, Losses = 0, Loves = "Confronting Evil", Wins = 0 },
                new Hamster { Id = 4, Age = 4, FavFood = "Pepper", ImgName = "hamster-4.jpg",
                    Name = "Grand Hamster", Games = 0, Losses = 0, Loves = "Sleeping", Wins = 0 },
                new Hamster { Id = 5, Age = 2, FavFood = "Banana", ImgName = "hamster-5.jpg",
                    Name = "Yellow Devil", Games = 0, Losses = 0, Loves = "Yellow things", Wins = 0 },
                new Hamster { Id = 6, Age = 1, FavFood = "Snickers", ImgName = "hamster-6.jpg",
                    Name = "Wingman", Games = 0, Losses = 0, Loves = "Helping others", Wins = 0 },
                new Hamster { Id = 7, Age = 1, FavFood = "Sugar", ImgName = "hamster-7.jpg",
                    Name = "Rincewind", Games = 0, Losses = 0, Loves = "Reading books", Wins = 0 },
                new Hamster { Id = 8, Age = 7, FavFood = "Candy", ImgName = "hamster-8.jpg",
                    Name = "Red dwarf", Games = 0, Losses = 0, Loves = "Small things", Wins = 0 },
                new Hamster { Id = 9, Age = 4, FavFood = "Ice cream", ImgName = "hamster-9.jpg",
                    Name = "Snowden", Games = 0, Losses = 0, Loves = "IoT", Wins = 0 },
                new Hamster { Id = 10, Age = 3, FavFood = "Ice cream", ImgName = "hamster-10.jpg",
                    Name = "Ice Queen", Games = 0, Losses = 0, Loves = "Snowmen", Wins = 0 }
                );
            modelBuilder.Entity<Match>().HasData(
                new Match { Id = 1, StartDate = DateTime.Now, IsCompleted = false, EndDate = null },
                new Match { Id = 2, StartDate = DateTime.Now, IsCompleted = true, EndDate = null },
                new Match { Id = 3, StartDate = DateTime.Now, IsCompleted = false, EndDate = null },
                new Match { Id = 4, StartDate = DateTime.Now, IsCompleted = false, EndDate = null },
                new Match { Id = 5, StartDate = DateTime.Now, IsCompleted = true, EndDate = null },
                new Match { Id = 6, StartDate = DateTime.Now, IsCompleted = true, EndDate = null },
                new Match { Id = 7, StartDate = DateTime.Now, IsCompleted = true, EndDate = null }
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
                new HamsterMatches { HamsterId = 3, MatchId = 7, }
                );
            modelBuilder.Entity<Vote>().HasData(
                new Vote { Id = 1, MatchId = 1, HamsterId = 4 },
                new Vote { Id = 2, MatchId = 2, HamsterId = 4 },
                new Vote { Id = 3, MatchId = 2, HamsterId = 7 },
                new Vote { Id = 4, MatchId = 2, HamsterId = 7 },
                new Vote { Id = 5, MatchId = 2, HamsterId = 7 },
                new Vote { Id = 6, MatchId = 2, HamsterId = 7 },
                new Vote { Id = 7, MatchId = 2, HamsterId = 4 },
                new Vote { Id = 8, MatchId = 2, HamsterId = 4 },
                new Vote { Id = 9, MatchId = 2, HamsterId = 7 },
                new Vote { Id = 10, MatchId = 5, HamsterId = 4 },
                new Vote { Id = 11, MatchId = 6, HamsterId = 10 }, 
                new Vote { Id = 12, MatchId = 7, HamsterId = 8 }
                );
        }
    }
}
