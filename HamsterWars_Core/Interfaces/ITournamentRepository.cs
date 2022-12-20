using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Interfaces
{
    public interface ITournamentRepository
    {
        Task<IEnumerable<TournamentDTO>> GetTournaments();
        Task<TournamentDTO> GetTournamentByID(int tournamentId);
        Task<int> CreateTournament(int[] hamsters, string title);
        Task<bool> CheckTournamentMatches(int tourId);
    }
}
