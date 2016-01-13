using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Shared.HttpClient
{
    public class SimpleHttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public SimpleHttpClient()
        {
            _httpClient = new System.Net.Http.HttpClient();
        }

        public void SendHttpRequest(HttpMethod httpMethod, string url)
        {
            var result = _httpClient.SendAsync(new HttpRequestMessage(httpMethod, url));
        }
    }
}
