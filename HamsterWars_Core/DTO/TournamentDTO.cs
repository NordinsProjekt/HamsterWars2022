using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public class TournamentDTO
    {
        private int id;
        private string name;
        private List<MatchFullDTO> matches;
        private DateTime startdate;
        private DateTime? enddate;
        private bool isCompleted;
        public TournamentDTO(int id, string name, List<MatchFullDTO> matches, DateTime startdate,DateTime enddate, bool isCompleted) 
        { 
            this.id = id;
            this.name = name;
            this.matches = matches;
            this.startdate = startdate;
            this.enddate = enddate;
            this.isCompleted = isCompleted;
        }

    }
}
