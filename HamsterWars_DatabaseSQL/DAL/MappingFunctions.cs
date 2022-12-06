using HamsterWars_Core.DTO;
using HamsterWars_DatabaseSQL.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public static class MappingFunctions
    {
        public static HamsterFullDTO MapHamsterToHamsterFullDTO(Hamster hamster)
        {
            var hamsterDTO = hamster.Adapt<HamsterFullDTO>();
            return hamsterDTO;
        }

        public static IEnumerable<HamsterFullDTO> MapHamsterToHamsterFullDTOList(List<Hamster> hamsterList)
        {
            List<HamsterFullDTO> list = new List<HamsterFullDTO>();
            foreach (var hamster in hamsterList)
                list.Add(hamster.Adapt<HamsterFullDTO>());
            return list;
        }

        public static Hamster MapHamsterCreateDTOToHamsterEntity(HamsterCreateDTO hamster)
            => hamster.Adapt<Hamster>();

        public static Hamster MapHamsterPatchDTOToHamsterEntity(HamsterPatchDTO hamster)
            => hamster.Adapt<Hamster>();
        public static IEnumerable<MatchDTO> MapMatchListToMatchDTOList(List<Match> matches)
        {
            List<MatchDTO> list = new List<MatchDTO>();
            foreach (var match in matches)
                list.Add(match.Adapt<MatchDTO>());
            return list;
        }
        public static MatchFullDTO MapMatchToMatchFullDTO(Match match)
            => match.Adapt<MatchFullDTO>();
    }
}
