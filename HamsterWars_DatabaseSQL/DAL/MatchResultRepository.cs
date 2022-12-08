using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public class MatchResultRepository : IMatchResultRepository, IDisposable
    {
        private bool disposedValue;
        private HamsterContext _context;
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

        public IEnumerable<HamsterDTO> GetTop5Hamsters()
            => MappingFunctions.MapHamsterListToHamsterDTOList(_context.Hamsters.OrderByDescending(x => x.Wins).Take(5).ToList());

        public IEnumerable<HamsterDTO> GetLow5Hamsters()
            => MappingFunctions.MapHamsterListToHamsterDTOList(_context.Hamsters.OrderByDescending(x => x.Losses).Take(5).ToList());
        public IEnumerable<MatchResultDTO> GetMatchWinners(int hamsterId)
            => MappingFunctions.MapMatchResultListToMatchResultDTOList(_context.MatchResults.Include(x=>x.Winner)
                .Include(y=>y.Looser).Where(hamster=>hamster.WinnerId == hamsterId).ToList());
        public async Task Save() => await _context.SaveChangesAsync();
    }
}
