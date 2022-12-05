using HamsterWars_DatabaseSQL.Models;
using HamsterWars_Core.Interfaces;
using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public bool UpdateHamster(object changes)
        {
            throw new NotImplementedException();
        }

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

        public bool UpdateHamster(HamsterDTO changes)
        {
            _context.Entry(changes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return true;
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

        Task<bool> IHamsterRepository.UpdateHamster(HamsterDTO changes)
        {
            throw new NotImplementedException();
        }
    }
}
