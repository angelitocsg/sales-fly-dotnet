using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using SalesFly.API.DataModels;
using SalesFly.API.Interfaces;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class AeroportosRepository : IAeroportosRepository
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

            AeroportoDataModel[] aeroportosDataModel = await responseMessage.Content.ReadFromJsonAsync<AeroportoDataModel[]>(options);

            IEnumerable<Aeroporto> aeroportos = aeroportosDataModel
                .Select(it => new Aeroporto(
                   nome: it.nome,
                   sigla: it.aeroporto,
                   cidade: it.cidade
               ))
               .OrderBy(it => $"{it.Cidade}_{it.Nome}");

            return aeroportos;
        }
    }
}
