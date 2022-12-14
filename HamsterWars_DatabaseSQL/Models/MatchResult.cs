using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
    public class MatchResult
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int? WinnerId { get; set; }
        public int? LooserId { get; set; }
        [ForeignKey("WinnerId")]
        public virtual Hamster? Winner { get; set; }
        public int WinnerScore { get; set; }
        [ForeignKey("LooserId")]
        public virtual Hamster? Looser { get; set; }
        public int LooserScore { get; set; }
    }
}
