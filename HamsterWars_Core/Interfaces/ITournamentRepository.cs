﻿using HamsterWars_Core.DTO;
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
        Task<bool> CreateTournament(int[] hamsters, string title);
    }
}