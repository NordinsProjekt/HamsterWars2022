using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterWars_Core.DTO;

namespace HamsterWars_Core.Interfaces
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<HamsterDTO>> GetHamsters();
        HamsterFullDTO RandomHamster();
        Task<IEnumerable<HamsterMiniDTO>> GetHamstersMinimal();
        Task<HamsterFullDTO> GetHamsterByID(int hamsterId);
        Task<HamsterFullDTO> InsertHamsterAsync(HamsterCreateDTO hamster);
        Task<bool> UpdateHamster(HamsterPatchDTO changes,int hamsterId);
        Task<bool> RestoreHamster(int id);
        public Task<bool> DeleteHamster(int hamsterId);
        public Task Save();
    }
}
