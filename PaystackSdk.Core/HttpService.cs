using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace PaystackSdk.Core
{
    internal class HttpService
    {
        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<TOut>> Post<TIn, TOut>(string url, TIn data)
        {
            var result = await _httpClient.PostAsJsonAsync(url, data);

            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<TOut>>(content);
        }

        public async Task<Response<TOut>> Get<TOut>(string url)
        {
            var result = await _httpClient.GetAsync(url);

            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<TOut>>(content);
        }
    }
}
