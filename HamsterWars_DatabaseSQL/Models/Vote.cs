using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int HamsterId { get; set; }
    }
}
