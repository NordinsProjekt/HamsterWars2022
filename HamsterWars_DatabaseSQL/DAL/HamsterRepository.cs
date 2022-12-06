using HamsterWars_DatabaseSQL.Models;
using HamsterWars_Core.Interfaces;
using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mapster;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Numerics;

namespace HamsterWars_DatabaseSQL.DAL
{
    public class HamsterRepository : IHamsterRepository, IDisposable
    {
        private bool disposedValue;
        private HamsterContext _context;
        private Random rnd = new Random();

        public HamsterRepository(HamsterContext context) => _context = context;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
                if (disposing)
                    _context.Dispose();
                disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public async Task Save() => await _context.SaveChangesAsync();

        IEnumerable<HamsterFullDTO> IHamsterRepository.GetHamsters()
            => MappingFunctions.MapHamsterToHamsterFullDTOList(_context.Hamsters.Include(match => match.Matches).ToList());

        HamsterFullDTO IHamsterRepository.RandomHamster()
            => MappingFunctions.MapHamsterToHamsterFullDTO(_context.Hamsters.Include(match => match.Matches).ToList()
                .ElementAt(rnd.Next(_context.Hamsters.Count())));
        HamsterFullDTO IHamsterRepository.GetHamsterByID(int hamsterId) 
            => MappingFunctions.MapHamsterToHamsterFullDTO(_context.Hamsters.Where(hamster => hamster.Id == hamsterId).FirstOrDefault());

        public async Task<HamsterFullDTO> InsertHamsterAsync(HamsterCreateDTO hamster)
        {
            Hamster hamsterEntity = MappingFunctions.MapHamsterCreateDTOToHamsterEntity(hamster);
            await _context.AddAsync(hamsterEntity);
            await Save();
            return MappingFunctions.MapHamsterToHamsterFullDTO(hamsterEntity);
        }

        async Task<bool> IHamsterRepository.DeleteHamster(int hamsterId)
        {
            Hamster hamster = _context.Hamsters.Where(x=>x.Id == hamsterId).FirstOrDefault();
            if (hamster != null)
            {
                _context.Remove(hamster);
                await Save();
                return true;
            }
            return false;
        }
        async Task<bool> IHamsterRepository.UpdateHamster(HamsterPatchDTO changes,int hamsterId)
        {
            Hamster org = _context.Hamsters.Where(x=>x.Id==hamsterId).FirstOrDefault();
            if (org != null)
            {
                foreach (var item in changes.GetType().GetProperties())
                {
                    var value = item.GetValue(changes, null);
                    if (value != null)
                    {
                        org.GetType().GetProperty(item.Name).SetValue(org, value, null);
                    }
                }
                _context.Update(org);
                await Save();
                return true;
            }
            else
                return false;
        }
    }
}
