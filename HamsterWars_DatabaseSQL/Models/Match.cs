using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
    public class Match
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
        public List<Hamster> Contestants { get; set; } = new List<Hamster>();
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set;}

    }
}
