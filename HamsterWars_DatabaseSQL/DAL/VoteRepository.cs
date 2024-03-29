﻿using HamsterWars_Core.DTO;
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
    public class VoteRepository : IVoteRepository, IDisposable
    {
        private bool disposedValue;
        private HamsterContext _context;

        public VoteRepository(HamsterContext context) => _context = context;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async Task Save() => await _context.SaveChangesAsync();

        public async Task<bool> VoteOnMatch(VoteDTO vote)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Models.Match m = _context.Matches.Include(x=>x.Contestants).Where(id=>id.Id == vote.MatchId).SingleOrDefault();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (m.IsCompleted == true)
                return false;
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            if (m == null || m.Contestants.Where(x=>x.Id == vote.HamsterId).FirstOrDefault() == null)
                return false;

            Vote v = MappingFunctions.MapVoteDTOToVote(vote);
            await _context.AddAsync(v);
            await Save();
            return true;
        }
    }
}
