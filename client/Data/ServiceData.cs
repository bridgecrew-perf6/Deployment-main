using System;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Model;

namespace TodoListBlazor.Data
{
    public class ServiceData
    {
        private readonly HttpClient http;
        private readonly IConfiguration configuration;
        private readonly string baseAPI = "";

        public ServiceData(HttpClient http, IConfiguration configuration)
        {
            this.http = http;
            this.configuration = configuration;
            this.baseAPI = configuration["base_api"];
        }

        public async Task<Questions[]> GetTaskData()
        {
            string url = $"{baseAPI}api/questions/";
            return await http.GetFromJsonAsync<Questions[]>(url);
        }
        
    }
}

