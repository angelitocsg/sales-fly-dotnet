using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SalesFly.Shared.Models;
using SalesFly.UI.Interfaces;

namespace SalesFly.UI.Services
{
    public class AeroportoService : IAeroportoService
    {
        private readonly HttpClient _httpClient;

        public AeroportoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Aeroporto>> GetAeroportosAsync()
        {
            HttpResponseMessage httpResponse = await _httpClient.GetAsync("Aeroportos");
            Aeroporto[] aeroportos = await httpResponse.Content.ReadFromJsonAsync<Aeroporto[]>();
            return aeroportos;
        }
    }
}
