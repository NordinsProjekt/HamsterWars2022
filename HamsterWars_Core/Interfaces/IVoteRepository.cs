using HamsterWars_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Interfaces
{
    public interface IVoteRepository
    {
        public Task<bool> VoteOnMatch(VoteDTO vote);
        public Task Save();
    }
}
