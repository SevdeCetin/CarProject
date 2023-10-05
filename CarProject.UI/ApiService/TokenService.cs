using CarProject.UI.Models.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CarProject.UI.ApiService
{
    public class TokenService
    {
        private readonly HttpClient _client;
        public TokenService(HttpClient httpClient)
        {
            _client = httpClient;
        }
        public async Task<string> GetToken(LoginDTO dto)
        {
            string responseToken = null;
            var strContent = new StringContent(JsonConvert.SerializeObject(dto));
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync("Auth/Login", strContent);
            if (response.IsSuccessStatusCode)
            {
                responseToken = await response.Content.ReadAsStringAsync();
            }
            return responseToken;
        }
    }
}
