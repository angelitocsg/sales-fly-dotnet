using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SalesFly.Shared.Models;
using SalesFly.UI.Interfaces;

namespace SalesFly.UI.Services
{
    public class VooService : IVooService
    {
        private readonly HttpClient _httpClient;

        public VooService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Voo>> GetVoosAsync(string origem, string destino, DateTime data)
        {
            HttpResponseMessage httpResponse = await _httpClient.GetAsync($"Voos/{origem}/{destino}/{data.ToString("yyyy-MM-dd")}");
            Voo[] voos = await httpResponse.Content.ReadFromJsonAsync<Voo[]>();
            return voos;
        }
    }
}
