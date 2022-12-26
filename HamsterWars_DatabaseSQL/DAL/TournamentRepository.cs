using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            => MappingFunctions.MapTournamentListToTournamentDTOList(await _context.Tournaments
                .Include(m => m.Matches).ThenInclude(mr => mr.Result).ThenInclude(w => w.Winner)
                .Include(m => m.Matches).ThenInclude(mr => mr.Result).ThenInclude(l => l.Looser)
                .ToListAsync());

        public async Task<TournamentDTO> GetTournamentByID(int tournamentId)
            => MappingFunctions.MapTournamentToTournamentDTO(await _context.Tournaments
                .Include(m=>m.Matches).ThenInclude(h=>h.Contestants)
                .Include(m=>m.Matches).ThenInclude(r=>r.Result)
                .Where(x => x.Id == tournamentId).FirstOrDefaultAsync());

        public async Task<int> CreateTournament(int[] hamsters, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return -1;
            if (hamsters.Length % 2 != 0)
                return -1;
            var hList = await _context.Hamsters.Where(item => hamsters.Contains(item.Id)).ToListAsync();
            if (hList.Count == 0)
                return -1;
            var mList = GetMatchesFromHamsterList(hList);
            _context.AddRange(mList);
            Tournament t = new Tournament();
            t.Title= title;
            t.StartDate = DateTime.Now;
            t.Matches = mList;
            t.NumberOfConsestants = hamsters.Length;
            _context.Add(t);
            await _context.SaveChangesAsync();
            return t.Id;
        }

        public async Task<bool> CheckTournamentMatches(int tourId)
        {
            Tournament? t = await _context.Tournaments.Include(m=>m.Matches).ThenInclude(mr=>mr.Result).ThenInclude(w=>w.Winner).FirstOrDefaultAsync(x=>x.Id == tourId);
            if (t == null) return false;
            if (t.IsCompleted) return false;

            int cMatches = t.Matches.Count;
            int cMatchesDone = t.Matches.Count(x => x.IsCompleted == true);

            if ((t.NumberOfConsestants - cMatchesDone) <= 1)
            {
                t.IsCompleted = true;
                t.EndDate= DateTime.Now;
                _context.Update(t);
                await _context.SaveChangesAsync();
                return true;
            }
            if (cMatches != cMatchesDone) return false;

            int numOfCon = t.NumberOfConsestants;
            Match[] matchArr = t.Matches.OrderByDescending(t => t.TId).ToArray();
            int max = (numOfCon - cMatchesDone);
            int tIdCounter = (int)matchArr[0].TId;
            matchArr = matchArr.Take(max).OrderBy(x=>x.TId).ToArray();
            for (int i = 0; i < max; i+=2)
            {
                List<Hamster> hList = new List<Hamster>();
                hList.Add(matchArr[i].Result.Winner);
                hList.Add(matchArr[i+1].Result.Winner);
                Match m = new Match() { StartDate= DateTime.Now, Contestants = hList, Tour = t, TId = ++tIdCounter };
                _context.Add(m);
            }
            await _context.SaveChangesAsync();
            return true;
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

        public async Task<IEnumerable<TournamentMiniDTO>> GetTournamentsDone()
            => await _context.Tournaments.Where(done=>done.IsCompleted == true)
                .ProjectToType<TournamentMiniDTO>().ToListAsync();

        public async Task<IEnumerable<TournamentMiniDTO>> GetTournamentsOngoing()
            => MappingFunctions.MapTournamentListToTournamentMiniDTOList(await _context.Tournaments.Where(done => done.IsCompleted == false).Where(m => m.IsCompleted == false)
                .ToListAsync());
    }
}
