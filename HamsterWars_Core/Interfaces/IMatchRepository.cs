﻿using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Interfaces
{
    public interface IMatchRepository
    {
        Task<IEnumerable<MatchDTO>> GetMatches();
        Task<MatchFullDTO> GetMatchByID(int matchId);
        Task<IEnumerable<MatchFullDTO>> Get10Lastest();
        Task<IEnumerable<MatchDTO>> GetBetweenDates(DateOnly startDate, DateOnly endDate, int hamsterId);
        Task<MatchFullDTO> InsertMatch(MatchCreateDTO match);
        Task<bool> DeleteMatch(int matchId);
        public Task<bool> EndMatchAndCountVotes(int id);
        public Task Save();
    }
}
