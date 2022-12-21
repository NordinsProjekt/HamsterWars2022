using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
   public class Hamster
   {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int Age { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'FavFood' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string FavFood { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'FavFood' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Loves' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Loves { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Loves' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'ImgName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string ImgName { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'ImgName' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Games { get; set; }
        public bool IsDeleted { get; set; } = false;
#pragma warning disable CS8618 // Non-nullable property 'Matches' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Match> Matches { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Matches' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'MatchResultsWinner' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<MatchResult> MatchResultsWinner { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'MatchResultsWinner' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'MatchResultsLooser' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<MatchResult> MatchResultsLooser { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'MatchResultsLooser' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
    }
}
