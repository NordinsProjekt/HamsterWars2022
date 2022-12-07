using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
    public class MatchResult
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Hamster Winner { get; set; }
        public int WinnerScore { get; set; }
        public Hamster Looser { get; set; }
        public int LooserScore { get; set; }
    }
}
