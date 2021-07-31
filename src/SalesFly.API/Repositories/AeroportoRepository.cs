using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class AeroportoRepository : IAeroportoRepository
    {
        public async Task<IEnumerable<Aeroporto>> GetAsync()
        {
            var url = "https://raw.githubusercontent.com/tegraoss/desafio-tegra/master/aeroportos.json";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            Aeroporto[] aeroporto = await responseMessage.Content.ReadFromJsonAsync<Aeroporto[]>(options);

            return aeroporto;
        }
    }
}
