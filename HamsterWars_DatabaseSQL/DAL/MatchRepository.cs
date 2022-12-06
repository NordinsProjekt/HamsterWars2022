using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            => MappingFunctions.MapMatchToMatchFullDTO(_context.Matches
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

        public MatchDTO[] GetAllWonMatches(int hamsterId)
        {
            throw new NotImplementedException();
        }

        public HamsterDTO[] GetTop5WinnerHamsters()
        {
            throw new NotImplementedException();
        }

        public HamsterDTO[] GetTop5LoserHamsters()
        {
            throw new NotImplementedException();
        }

        public async Task Save() => await _context.SaveChangesAsync();

        MatchCreateDTO IMatchRepository.InsertMatch(MatchDTO match)
        {
            throw new NotImplementedException();
        }
    }
}
