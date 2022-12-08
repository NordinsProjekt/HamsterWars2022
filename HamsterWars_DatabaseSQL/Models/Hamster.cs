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
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavFood { get; set; }
        public string Loves { get; set; }
        public string ImgName { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Games { get; set; }
        public List<Match> Matches { get; set; }
        public List<MatchResult> MatchResultsWinner { get; set; }
        public List<MatchResult> MatchResultsLooser { get; set; }
    }
}
