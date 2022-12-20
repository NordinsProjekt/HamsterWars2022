using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public class MatchRepository : IMatchRepository, IDisposable
    {
        private bool disposedValue;
        private readonly HamsterContext _context;
        private readonly Random rnd = new();
        public MatchRepository(HamsterContext context) => _context = context;
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

        public async Task<IEnumerable<MatchDTO>> GetMatches() 
            => MappingFunctions.MapMatchListToMatchDTOList(await _context.Matches.Include(hamster => hamster.Contestants).Include(ma=>ma.Result).ToListAsync());

        public async Task<MatchFullDTO> GetMatchByID(int matchId)
            => MappingFunctions.MapMatchToMatchFullDTO(await _context.Matches.Include(hamster => hamster.Contestants)
                .Where(match => match.Id == matchId).FirstOrDefaultAsync());

        public async Task<bool> DeleteMatch(int matchId)
        {
            Match? match = await _context.Matches.Where(x=> x.Id == matchId).FirstOrDefaultAsync();
            if (match != null)
            {
                _context.Matches.Remove(match);
                await Save();
                return true;
            }
            return false;
        }

        public async Task Save() => await _context.SaveChangesAsync();

        public async Task<MatchFullDTO> InsertMatch(MatchCreateDTO match)
        {
            Hamster? cons1 = await _context.Hamsters.Where(x=>x.Id == match.Hamster1Id).Where(y => y.IsDeleted == false).FirstOrDefaultAsync();
            Hamster? cons2 = await _context.Hamsters.Where(x => x.Id == match.Hamster2Id).Where(y => y.IsDeleted == false).FirstOrDefaultAsync();
            if (cons1!= null && cons2 != null)
            {
                Match m = new();
                m.Contestants.Add(cons1);
                m.Contestants.Add(cons2);
                m.StartDate = match.StartDate;
                m.EndDate = match.EndDate;
                _context.Add(m);
                await Save();
                return MappingFunctions.MapMatchToMatchFullDTO(m);
            }
            else
            {
                throw new ArgumentException("Hamster or Hamsters doesnt exists");
            }
        }

        public async Task<bool> EndMatchAndCountVotes(int id)
        {
            Match? m = await _context.Matches.Include(h=>h.Contestants).Where(x=>x.Id == id).FirstOrDefaultAsync();
            if (m == null)
                return false;

            m.IsCompleted = true;
            var result = await _context.Votes.Where(x => x.MatchId == id).ToListAsync();

            if (result.Count == 0)
                return true;

            var winner = result.GroupBy(h => new { h.HamsterId },
                (key, items) => new { key.HamsterId, Count = items.Count() }).OrderByDescending(x => x.Count).ToList();
            
            MatchResult mr = new MatchResult();
            mr.MatchId = id;
            //Detta kommer "slumpa" en vinnare om det är samma resultat.
            foreach (var hamster in m.Contestants)
            {
                if (hamster.Id == winner[0].HamsterId)
                {
                    hamster.Wins++;
                    mr.Winner = hamster;
                    mr.WinnerScore = winner[0].Count;
                } 
                else
                {
                    hamster.Losses++;
                    mr.Looser = hamster;
                    if (winner.Count == 1)
                        mr.LooserScore = 0;
                    else
                        mr.LooserScore = winner[1].Count;
                }
                hamster.Games++;
            }
            _context.RemoveRange(result);
            _context.Add(mr);
            _context.Update(m);
            await Save();
            return true;
        }
    }
}
