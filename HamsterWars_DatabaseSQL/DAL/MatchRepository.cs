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
        private HamsterContext _context;
        private Random rnd = new Random();
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

        public IEnumerable<MatchDTO> GetMatches() 
            => MappingFunctions.MapMatchListToMatchDTOList(_context.Matches.Include(hamster => hamster.Contestants).ToList());

        public MatchFullDTO GetMatchByID(int matchId)
            => MappingFunctions.MapMatchToMatchFullDTO(_context.Matches.Include(hamster => hamster.Contestants)
                .Where(match => match.Id == matchId).FirstOrDefault());

        public async Task<bool> DeleteMatch(int matchId)
        {
            Match match = _context.Matches.Where(x=> x.Id == matchId).FirstOrDefault();
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
            Hamster cons1 = await _context.Hamsters.Where(x=>x.Id == match.Hamster1Id).FirstOrDefaultAsync();
            Hamster cons2 = await _context.Hamsters.Where(x => x.Id == match.Hamster2Id).FirstOrDefaultAsync();
            if (cons1!= null && cons2 != null)
            {
                Match m = new Match();
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
            Match m = _context.Matches.Include(h=>h.Contestants).Where(x=>x.Id == id).FirstOrDefault();
            if (m == null)
                return false;

            m.IsCompleted = true;
            var result = _context.Votes.Where(x => x.MatchId == id).ToList();

            if (result.Count == 0)
                return true;

            var winner = result.GroupBy(h => new { h.HamsterId },
                (key, items) => new { key.HamsterId, Count = items.Count() }).OrderByDescending(x => x.Count).ToList();
            
            MatchResult mr = new MatchResult();
            mr.MatchId = id;
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
