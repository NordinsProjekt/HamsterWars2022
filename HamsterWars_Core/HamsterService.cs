using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars_Core
{
    public class HamsterService
    {
        private string _apiPath;
        private HttpClient _httpClient;
        public HamsterService(string apiPath) 
        {
            _apiPath= apiPath;
        }

        public void Connect()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_apiPath);
        }
    }
}
