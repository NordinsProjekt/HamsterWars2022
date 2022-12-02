using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamsterWars_DatabaseSQL.Models;

namespace HamsterWars_DatabaseSQL.DAL
{
    public interface IHamsterRepository
    {
        IEnumerable<Hamster> GetHamsters();
        Hamster RandomHamster();
        Hamster GetHamsterByID(int hamsterId);
        Hamster InsertHamster(Hamster hamster);
        bool UpdateHamster(object changes);
        bool DeleteHamster(int hamsterId);
    }
}
