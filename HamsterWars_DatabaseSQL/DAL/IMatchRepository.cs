using HamsterWars_DatabaseSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public interface IMatchRepository
    {
        IEnumerable<Match> GetMatches();
        Match GetMatchByID(int matchId);
        object InsertMatch(Match match);
        bool DeleteMatch(int matchId);
        Match[] GetAllWonMatches(int hamsterId);
        Hamster[] GetTop5WinnerHamsters();
        Hamster[] GetTop5LoserHamsters();
    }
}
