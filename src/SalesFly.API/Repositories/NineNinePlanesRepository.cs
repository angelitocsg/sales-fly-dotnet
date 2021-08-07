using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SalesFly.API.DataModels;
using SalesFly.Shared.Models;

namespace SalesFly.API.Repositories
{
    public class NineNinePlanesRepository : IVoosRepository
    {
        private async Task<string> Load()
        {
            var url = "https://raw.githubusercontent.com/tegraoss/desafio-tegra/master/99planes.json";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);

            var data = await responseMessage.Content.ReadAsStringAsync();

            return data;
        }

        public async Task<IEnumerable<Voo>> GetAsync()
        {
            string nineNinePlanes = await Load();
            var dataJson = JArray.Parse(nineNinePlanes);
            var voos = new List<Voo>();

            foreach (var line in dataJson)
            {
                var model = line.ToObject<VooDataModel>();

                var voo = new Voo(
                    empresa: "99 Planes",
                    numeroVoo: model.voo,
                    origem: model.origem,
                    destino: model.destino,
                    dataSaida: Convert.ToDateTime(model.data_saida),
                    saida: model.saida,
                    chegada: model.chegada,
                    valor: model.valor
                );

                voos.Add(voo);
            }

            return voos;
        }
    }
}
