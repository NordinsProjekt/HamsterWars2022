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
                    Name = "Protector of the Wastelands", Games = 0, Losses = 0, Loves = "Confronting Evil", Wins = 0 }
                );
            modelBuilder.Entity<Match>().HasData(
                new Match { Id = 1, StartDate = DateTime.Now, IsCompleted = false, EndDate = null });
            modelBuilder.Entity<HamsterMatches>().HasData(
                new HamsterMatches { HamsterId= 1, MatchId= 1,},
                new HamsterMatches { HamsterId = 2, MatchId = 1 });
            modelBuilder.Entity<Vote>().HasData(new Vote { Id = 1, MatchId = 1, HamsterId = 2 });
        }
    }
}
