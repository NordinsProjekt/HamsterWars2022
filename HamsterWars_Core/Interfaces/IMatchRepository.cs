using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Interfaces
{
    public interface IMatchRepository
    {
        IEnumerable<MatchDTO> GetMatches();
        MatchFullDTO GetMatchByID(int matchId);
        Task<MatchFullDTO> InsertMatch(MatchCreateDTO match);
        Task<bool> DeleteMatch(int matchId);
        MatchDTO[] GetAllWonMatches(int hamsterId);
        HamsterDTO[] GetTop5WinnerHamsters();
        HamsterDTO[] GetTop5LoserHamsters();
        public Task Save();
    }
}
