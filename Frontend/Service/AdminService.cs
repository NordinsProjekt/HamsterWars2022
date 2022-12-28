using Frontend.DTO;
namespace Frontend.Service
{
    public class AdminService
    {
        private string _api;
        private HttpClient _httpClient = new HttpClient();
        public AdminService(string apiRoute)
        { 
            _api = apiRoute;
            _httpClient.BaseAddress = new Uri(_api);
        }

        public async Task<bool> VoteInBattle(int[] arr)
        {
            VoteDTO vote = new VoteDTO(arr[0], arr[1]);
            await _httpClient.PostAsJsonAsync("vote", vote);
            await _httpClient.PostAsJsonAsync("EndMatch", arr[0]);
            _httpClient.Dispose();
            //await JS.InvokeVoidAsync("postAPI", "https://localhost:7101/vote/", vote);
            //await JS.InvokeVoidAsync("postAPI", "https://localhost:7101/EndMatch/" + matchVote[0]);
            return true;
        }
    }
}
