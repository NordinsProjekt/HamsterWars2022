using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public class MatchResultRepository : IMatchResultRepository, IDisposable
    {
        private bool disposedValue;
        private readonly HamsterContext _context;
        public MatchResultRepository(HamsterContext context) => _context = context;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
                if (disposing)
                    _context.Dispose();
            disposedValue = true;
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<HamsterDTO>> GetTop5Hamsters()
            => MappingFunctions.MapHamsterListToHamsterDTOList(await _context.Hamsters.OrderByDescending(x => x.Wins).Take(5).ToListAsync());

        public async Task<IEnumerable<HamsterDTO>> GetLow5Hamsters()
            => MappingFunctions.MapHamsterListToHamsterDTOList(await _context.Hamsters.OrderByDescending(x => x.Losses).Take(5).ToListAsync());
        public async Task<MatchResultDTO[]> GetMatchWinners(int hamsterId)
        {
            var result = MappingFunctions.MapMatchResultListToMatchResultDTOList(await _context.MatchResults.Include(x => x.Winner)
                .Include(y => y.Looser).Where(hamster => hamster.WinnerId == hamsterId).ToListAsync());
            MatchResultDTO[] arr = result.ToArray();
            return arr;
        }

        public async Task Save() => await _context.SaveChangesAsync();

        public async Task<int?[]> GetDefeatedHamsters(int winnerHamsterId)
        {
            Hamster? winner = await _context.Hamsters.Where(x => x.Id == winnerHamsterId).FirstOrDefaultAsync();
            if (winner == null)
                throw new ArgumentException("Hamstern finns inte");
            var result = _context.MatchResults.Include(winner => winner.Winner).Include(loser=>loser.Looser)
                .Where(x=>x.WinnerId== winnerHamsterId).Select(los=>los.LooserId).Distinct().ToArray();
            return result;
        }

        public async Task<ScoreCardDTO> GetChallengerScoreCard(int challenger, int defender)
        {
            Hamster? cHamster = await _context.Hamsters.Where(x=>x.Id== challenger).FirstOrDefaultAsync();
            Hamster? dHamster = await _context.Hamsters.Where(x => x.Id == defender).FirstOrDefaultAsync();
            if (dHamster == null || cHamster == null)
                throw new ArgumentException("Hamstern finns inte");

            var challengerScore = await _context.MatchResults.Where(chall => chall.WinnerId == challenger)
                .Where(loss => loss.LooserId == defender).Select(x => x.WinnerId).CountAsync();
            var defenderScore = await _context.MatchResults.Where(chall => chall.WinnerId == defender)
                .Where(loss => loss.LooserId == challenger).Select(x => x.WinnerId).CountAsync();
            ScoreCardDTO card = new(challengerScore, defenderScore,
                MappingFunctions.MapHamsterToHamsterDTO(cHamster),
                MappingFunctions.MapHamsterToHamsterDTO(dHamster));
            return card;
        }

        public async Task<int[]> GetLowestGamesTop5()
            => await _context.Hamsters.OrderBy(x => x.Games).Select(y=>y.Id).Take(5).ToArrayAsync();

        public async Task<int[]> GetHighestGamesTop5()
            => await _context.Hamsters.OrderByDescending(x => x.Games).Select(y => y.Id).Take(5).ToArrayAsync();
        public async Task<IEnumerable<MatchResultDTO>> Get10Lastest()
            => MappingFunctions.MapMatchResultListToMatchResultDTOList(await _context.MatchResults.Include(w => w.Winner).Include(l => l.Looser)
                    .Where(x => x.WinnerId != null && x.LooserId != null)
                    .OrderByDescending(id => id.Id).Take(10).ToListAsync());

    }
}
