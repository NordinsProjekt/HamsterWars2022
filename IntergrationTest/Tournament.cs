using HamsterWars_Core.DTO;
using HamsterWars_DatabaseSQL;
using HamsterWars_DatabaseSQL.DAL;

namespace IntergrationTest
{
    [Trait("Create Tournament","Run Tournament to end")]
    public class Tournament
    {
        [Trait("Create Tournament", "Run Tournament to end")]
        [Fact]
        public async Task CreateTournamentWithEightHamsters_CheckTheEndResult_ShouldHaveAWinner_AND_IsCompletedTRUE()
        {
            HamsterContext _context = new HamsterContext();
            TournamentRepository tourRep = new TournamentRepository(_context);
            MatchResultRepository mrRep = new MatchResultRepository(_context);
            MatchRepository mRep = new MatchRepository(_context);
            VoteRepository vRep = new VoteRepository(_context);
            int[] hArr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            await tourRep.CreateTournament(hArr, "Call of Duty 2022");
            int index = _context.Tournaments.OrderByDescending(x => x.Id).Select(id => id.Id).First();
            for (int i = 0; i < 3; i++)
            {
                var t = await tourRep.GetTournamentByID(index);
                foreach (var match in t.Matches)
                {
                    VoteDTO v = new VoteDTO(match.Id, match.Contestants.First().Id);
                    await vRep.VoteOnMatch(v);
                    await mRep.EndMatchAndCountVotes(match.Id);
                }
                await tourRep.CheckTournamentMatches(index);
            }
            var tournament = await tourRep.GetTournamentByID(index);
            Assert.True(tournament.IsCompleted);
        }
    }
}