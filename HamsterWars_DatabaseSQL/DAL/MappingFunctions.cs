using HamsterWars_Core.DTO;
using HamsterWars_DatabaseSQL.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HamsterWars_DatabaseSQL.DAL
{
    public static class MappingFunctions
    {
        public static HamsterFullDTO MapHamsterToHamsterFullDTO(Hamster hamster)
            => hamster.Adapt<HamsterFullDTO>();

        public static IEnumerable<HamsterFullDTO> MapHamsterToHamsterFullDTOList(List<Hamster> hamsterList)
        {
            List<HamsterFullDTO> list = new List<HamsterFullDTO>();
            foreach (var hamster in hamsterList)
                list.Add(hamster.Adapt<HamsterFullDTO>());
            return list;
        }
        public static IEnumerable<HamsterDTO> MapHamsterListToHamsterDTOList(List<Hamster> hamsterList)
        {
            List<HamsterDTO> list = new List<HamsterDTO>();
            foreach (var hamster in hamsterList)
                list.Add(hamster.Adapt<HamsterDTO>());
            return list;
        }
        public static HamsterDTO MapHamsterToHamsterDTO(Hamster hamster)
            => hamster.Adapt<HamsterDTO>();
        public static Hamster MapHamsterCreateDTOToHamsterEntity(HamsterCreateDTO hamster)
            => hamster.Adapt<Hamster>();

        public static Hamster MapHamsterPatchDTOToHamsterEntity(HamsterPatchDTO hamster)
            => hamster.Adapt<Hamster>();
        public static IEnumerable<MatchDTO> MapMatchListToMatchDTOList(List<Models.Match> matches)
        {
            List<MatchDTO> list = new List<MatchDTO>();
            foreach (var match in matches)
                list.Add(match.Adapt<MatchDTO>());
            return list;
        }
        public static MatchFullDTO MapMatchToMatchFullDTO(Models.Match match)
            => match.Adapt<MatchFullDTO>();
        public static MatchResultDTO MapMatchResultToMatchResultDTO(MatchResult mr)
            => mr.Adapt<MatchResultDTO>();
        public static IEnumerable<MatchResultDTO> MapMatchResultListToMatchResultDTOList(List<Models.MatchResult> matchResults)
        {
            List<MatchResultDTO> list = new List<MatchResultDTO>();
            foreach (var mr in matchResults)
                list.Add(mr.Adapt<MatchResultDTO>());
            return list;
        }

        public static Vote MapVoteDTOToVote(VoteDTO vote)
            => vote.Adapt<Vote>();

    }
}
