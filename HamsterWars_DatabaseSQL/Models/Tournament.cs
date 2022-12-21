using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.Models
{
    public class Tournament
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Title' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Title { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Title' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public int NumberOfConsestants { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Matches' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<Match> Matches { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Matches' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
