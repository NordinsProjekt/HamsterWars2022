using Microsoft.JSInterop;
using Frontend.DTO;

namespace Frontend.Pages
{
    public partial class OngoingTournaments
    {
        List<TournamentMiniDTO> tournamentList { get; set; }
        TournamentDTO? tournament { get; set; }
        MatchDTO? match { get; set; }
        public bool HasVoted { get; set; } = false;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                tournamentList = await JS.InvokeAsync<List<TournamentMiniDTO>>("getAPI", "https://localhost:7232/tournament/ongoing");
                StateHasChanged();
            }
        }
        public void GetMatchForBattle(int matchId)
        {
            var m = tournament.Matches.Where(id => id.Id == matchId).FirstOrDefault();
            if (m != null)
                match = new MatchDTO(m.Id, m.Contestants);
            HasVoted = false;
        }

        public async Task GetTournament(int tourId)
            => tournament = await JS.InvokeAsync<TournamentDTO>("getAPI", "https://localhost:7232/tournament/" + tourId);

        public async Task ContinueTournament(int tourId)
        {
            await JS.InvokeVoidAsync("postVoidAPI", "https://localhost:7101/CheckTournament/" + tourId);
            tournamentList = await JS.InvokeAsync<List<TournamentMiniDTO>>("getAPI", "https://localhost:7232/tournament/ongoing");
        }

        public async Task EndMatch(int matchId)
        {
            await JS.InvokeVoidAsync("postVoidAPI", "https://localhost:7101/EndMatch/" + matchId);
            tournamentList = await JS.InvokeAsync<List<TournamentMiniDTO>>("getAPI", "https://localhost:7232/tournament/ongoing");
            tournament = null;
        }

        public async Task Vote(int[] arr)
        {
            VoteDTO v = new VoteDTO(arr[0], arr[1]);
            await JS.InvokeVoidAsync("postAPI", "https://localhost:7232/vote/", v);
            match = null;
            HasVoted = true;
        }
    }
}
