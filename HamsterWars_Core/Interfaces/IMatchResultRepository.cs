﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterWars_Core.DTO;

namespace HamsterWars_Core.Interfaces
{
    public interface IMatchResultRepository
    {
        public IEnumerable<HamsterDTO> GetTop5Hamsters();
        public IEnumerable<HamsterDTO> GetLow5Hamsters();
        public MatchResultDTO[] GetMatchWinners(int id);
        public int?[] GetDefeatedHamsters(int winnerHamsterId);
        public ScoreCardDTO GetChallengerScoreCard(int challenger, int defender);
        public int[] GetLowestGamesTop5();
        public int[] GetHighestGamesTop5();
        public Task Save();
    }
}