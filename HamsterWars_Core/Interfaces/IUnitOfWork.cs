using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IHamsterRepository Hamster { get; init; }
        public IMatchRepository Match { get; init; }
        public IMatchResultRepository MatchResult { get; init; }
        public ITournamentRepository Tournament { get; init; }
        public IVoteRepository Vote { get; init; }
    }
}
