using System;
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
        public Task Save();
    }
}
