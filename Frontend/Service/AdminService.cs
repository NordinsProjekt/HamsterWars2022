using Frontend.DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Frontend.Service
{
    public class AdminService
    {
        private string _api;
        public AdminService(string apiRoute)
        { 
            _api = apiRoute;
        }

        public async Task<bool> VoteInBattle(int[] arr)
        {
            VoteDTO v = new VoteDTO(arr[0], arr[1]);
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_api);
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                var r2 = await httpClient.PostAsJsonAsync("/vote", v);
                var r1 = await httpClient.PostAsync("/EndMatch/" + arr[0], null);
                if (r2.IsSuccessStatusCode && r1.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
