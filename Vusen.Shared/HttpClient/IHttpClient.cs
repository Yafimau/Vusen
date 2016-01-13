using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vusen.Shared.HttpClient
{
    public interface IHttpClient : IService
    {
        void SendHttpRequest(HttpMethod httpMethod, string url);
    }
}
