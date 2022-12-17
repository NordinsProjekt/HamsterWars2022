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
    public class TournamentRepository :ITournamentRepository , IDisposable
    {
        private bool disposedValue;
        private HamsterContext _context;

        public TournamentRepository(HamsterContext context) => _context = context;
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

        public async Task<IEnumerable<TournamentDTO>> GetTournaments()
            => MappingFunctions.MapTournamentListToTournamentDTOList(await _context.Tournaments.ToListAsync());

        public async Task<TournamentDTO> GetTournamentByID(int tournamentId)
            => MappingFunctions.MapTournamentToTournamentDTO(await _context.Tournaments.Include(m=>m.Matches).ThenInclude(h=>h.Contestants)
             .Where(x => x.Id == tournamentId).FirstOrDefaultAsync());

        public async Task<bool> CreateTournament(int[] hamsters, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return false;
            if (hamsters.Length % 2 != 0)
                return false;
            var hList = GetHamstersFromIdArray(hamsters);
            if (hList.Result.Count == 0)
                return false;
            var mList = GetMatchesFromHamsterList(hList.Result);
            _context.AddRange(mList);
            Tournament t = new Tournament();
            t.Title= title;
            t.StartDate = DateTime.Now;
            t.Matches = mList;
            _context.Add(t);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CheckTournamentMatches(int id)
        {
            Tournament? t = await _context.Tournaments.FirstOrDefaultAsync(x=>x.Id == id);
            if (t == null) return false;
            int cMatches = t.Matches.Count;
            int cMatchesDone = t.Matches.Count(x => x.IsCompleted == true);
            if (cMatches != cMatchesDone) return false;

            return true;
        }

        public async Task<List<Hamster>> GetHamstersFromIdArray(int[] hamsters)
        {
            List<Hamster> hList = new List<Hamster>();
            for (int i = 0; i < hamsters.Length; i++)
            {
                Hamster? h = await _context.Hamsters.Where(x => x.Id == hamsters[i]).FirstOrDefaultAsync();
                if (h != null) hList.Add(h);
                else
                    return new List<Hamster>();
            }
            return hList;
        }

        public List<Match> GetMatchesFromHamsterList(List<Hamster> hamsterList)
        {
            Random rnd = new Random();
            List<Match> matches = new List<Match>();
            int x = 1;
            while(hamsterList.Count != 0)
            {
                Match m = new Match();
                m.StartDate = DateTime.Now;
                int index = rnd.Next(hamsterList.Count);
                m.Contestants.Add(hamsterList[index]);
                hamsterList.RemoveAt(index);

                index = rnd.Next(hamsterList.Count);
                m.Contestants.Add(hamsterList[index]);
                hamsterList.RemoveAt(index);
                m.TId = x++; //should be bracket
                matches.Add(m);
            }
            return matches;
        }
    }
}
