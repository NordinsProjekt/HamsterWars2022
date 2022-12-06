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
        IEnumerable<HamsterFullDTO> GetHamsters();
        HamsterFullDTO RandomHamster();
        HamsterFullDTO GetHamsterByID(int hamsterId);
        Task<HamsterFullDTO> InsertHamsterAsync(HamsterCreateDTO hamster);
        Task<bool> UpdateHamster(HamsterPatchDTO changes,int hamsterId);
        public Task<bool> DeleteHamster(int hamsterId);
        public Task Save();
    }
}
