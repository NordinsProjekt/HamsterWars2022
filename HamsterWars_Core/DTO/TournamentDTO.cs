using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HamsterWars_Core.DTO
{
    public sealed record TournamentDTO(int Id, string Title,List<MatchFullDTO> Matches, 
        DateTime StartDate, DateTime EndDate, bool IsCompleted);
}
