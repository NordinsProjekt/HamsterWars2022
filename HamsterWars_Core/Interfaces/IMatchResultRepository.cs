using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterWars_Core.DTO;

namespace HamsterWars_Core.Interfaces
{
    public interface IMatchResultRepository
    {
        public Task<IEnumerable<HamsterDTO>> GetTop5Hamsters();
        public Task<IEnumerable<HamsterDTO>> GetLow5Hamsters();
        public Task<MatchResultDTO[]> GetMatchWinners(int id);
        public Task<List<HamsterMiniDTO>> GetDefeatedHamsters(int winnerHamsterId);
        public Task<ScoreCardDTO> GetChallengerScoreCard(int challenger, int defender);
        public Task<IEnumerable<MatchResultSlimDTO>> GetAllMatchResultForHamster(int id);
        public Task<int[]> GetLowestGamesTop5();
        public Task<int[]> GetHighestGamesTop5();
        public Task Save();
    }
}
